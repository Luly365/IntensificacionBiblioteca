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
    public class RepositorioAutores : IRepositorioAutores
    {
        private readonly SqlConnection _conexion;

        public RepositorioAutores(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Autores WHERE AutorId=@id";
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

        public bool Existe(Autor autor)
        {
            if (autor.AutorId == 0)
            {
                //nuevo autor
                string cadenaComando = "SELECT AutorId, NombreAutor FROM Autores WHERE NombreAutor=@nombreAutor";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            else
            {
                string cadenaComando = "SELECT AutorId, NombreAutor FROM Autores WHERE NombreAutor=@nombreAutor AND AutorId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);
                comando.Parameters.AddWithValue("@id", autor.AutorId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }



        }

        public List<Autor> GetAutores()
        {
            List<Autor> lista = new List<Autor>();
            try
            {
                string cadenaComando = "SELECT AutorId, NombreAutor FROM Autores";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Autor autor = ConstruirAutor(reader);
                    lista.Add(autor);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Autores");
            }
        }

        private Autor ConstruirAutor(SqlDataReader reader)
        {
            return new Autor
            {
                AutorId = reader.GetInt32(0),
                NombreAutor = reader.GetString(1)
            };
        }

        public Autor GetAutorPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Autor autor)
        {
            if (autor.AutorId == 0)
            {//guardar
                try
                {
                    string cadenaComando = "INSERT INTO Autores VALUES(@nombreAutor)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);

                    autor.AutorId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw new Exception("Error al intentar guardar el registro.");
                }
            }
            else
            {
                //editar
                try
                {
                    string cadenaComando = "UPDATE Autores SET NombreAutor=@nombreAutor WHERE AutorId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);
                    comando.Parameters.AddWithValue("@id", autor.AutorId);
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
