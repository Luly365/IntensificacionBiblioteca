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
    public class RepositorioPaises : IRepositorioPaises
    {//va a implementar la interface de paises
        //aca SI DEBO DESARROLLAR LOS METODOS

        private readonly SqlConnection _conexion;//defino la conexion que va a ser de tipo sql conexion
        public RepositorioPaises(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public List<Pais> GetPaises()
        {

            List<Pais> lista = new List<Pais>();

            try
            {
                string cadenaComando = "SELECT PaisId, NombrePais FROM Paises";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pais pais = ConstruirPais(reader);// cuando me construye el pais
                    lista.Add(pais);// se lo pongo a la lista
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer los paises");
            }
        }

        private Pais ConstruirPais(SqlDataReader reader)
        {
            return new Pais
            {
                PaisId = reader.GetInt32(0),
                NombrePais = reader.GetString(1)
            };
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Paises WHERE PaisId=@id";
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

        public bool Existe(Pais pais)
        {
            try
            {
                SqlCommand comando;
                //SqlDataReader reader = null;

                if (pais.PaisId == 0)
                {//nuevo pais
                    string cadenaComando = "SELECT PaisId, NombrePais FROM Paises WHERE NombrePais=@NombrePais";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@NombrePais", pais.NombrePais);

                }
                else
                {//edicion del pais
                    string cadenaComando = "SELECT PaisId, NombrePais FROM Paises WHERE NombrePais=@NombrePais AND PaisId<>@id";//nombre = pero con un id diferente 
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombrePais", pais.NombrePais);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                }

                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Pais GetPaisPorId(int id)
        {
            Pais pais = null;
            try
            {
                string cadenaComando =
                    "SELECT PaisId, NombrePais FROM Paises WHERE PaisId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    pais = ConstruirPais(reader);
                }
                reader.Close();
                return pais;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Paises");
            }
        }

        public void Guardar(Pais pais)
        {
            if (pais.PaisId==0)
            {//nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO Paises VALUES(@nombrePais)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@NombrePais", pais.NombrePais);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);

                    pais.PaisId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar el registro...");
                }
            }
            else
            {   //editar
                try
                {
                    string cadenaComando = "UPDATE Paises SET NombrePais=@nombrePais WHERE PaisId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombrePais", pais.NombrePais);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar modificar un registro...");
                }
            }

           
        }
    }
}
