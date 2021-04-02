using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioGeneros : IRepositorioGeneros
    {
        private readonly SqlConnection _conexion;
        public RepositorioGeneros(SqlConnection conexion)
        {
            _conexion = conexion;
        }


        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Generos WHERE GeneroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    throw new Exception("Registro con datos asociados... Baja denegada");
                }
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Genero genero)
        {
            if (genero.GeneroId == 0)
            {//nuevo genero
                string cadenaComando = "SELECT GeneroId, Descripcion FROM Generos WHERE Descripcion=@descripcion";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;

            }
            else
            {//edicion de genero
                string cadenaComando = "SELECT GeneroId, Descripcion FROM Generos WHERE Descripcion=@descripcion AND GeneroId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                comando.Parameters.AddWithValue("@id", genero.GeneroId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

        public Genero GetGeneroPorId(int id)
        {
            Genero genero = null;
            try
            {
                string cadenaComando =
                    "SELECT GeneroId, Descripcion FROM Generos WHERE GeneroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    genero = ConstruirGenero(reader);
                }
                reader.Close();
                return genero;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer las ciudades");
            }
        }

        public List<Genero> GetGeneros()
        {
            List<Genero> lista = new List<Genero>();
            try
            {
                string cadenaComando = "SELECT GeneroId, Descripcion FROM Generos";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Genero genero = ConstruirGenero(reader);
                    lista.Add(genero);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Generos");
            }
        }

        private Genero ConstruirGenero(SqlDataReader reader)
        {
            return new Genero
            {
                GeneroId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public void Guardar(Genero genero)
        {
            if (genero.GeneroId == 0)
            {
                //nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO Generos VALUES(@descripcion)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);

                    genero.GeneroId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar el registro.");
                }
            }
            else
            {   //editar
                try
                {
                    string cadenaComando = "UPDATE Generos SET Descripcion=@descripcion WHERE GeneroId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                    comando.Parameters.AddWithValue("@id", genero.GeneroId);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar modificar un registro.");
                }
            }
        }
    }
}
