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
    public class RepositorioProvincias : IRepositorioProvincias
    {
        //el repositorio necesita una conexion 
        private readonly SqlConnection _conexion;
        public RepositorioProvincias(SqlConnection conexion)
        {
            _conexion = conexion;
        }
        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Provincias WHERE ProvinciaId=@id";
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

        public bool Existe(Provincia provincia)
        {
            if (provincia.ProvinciaId == 0)
            {
                //nueva provincia
                string cadenaComando = "SELECT ProvinciaId, NombreProvincia FROM Provincias WHERE NombreProvincia=@nombre";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;


            }
            else
            {
                //edicion de la provincia
                string cadenaComando = "SELECT ProvinciaId, NombreProvincia FROM Provincias WHERE NombreProvincia=@nombreprovincia AND ProvinciaId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombreprovincia", provincia.NombreProvincia);
                comando.Parameters.AddWithValue("@id", provincia.ProvinciaId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
        }

        public Provincia GetProvinciaPorId(int id)
        {
            Provincia provincia = null;
            try
            {
                string cadenaComando =
                    "SELECT ProvinciaId, NombreProvincia FROM Provincias WHERE ProvinciaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    provincia = ConstruirProvincia(reader);
                }
                reader.Close();
                return provincia;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer las Provincias");
            }
        }

        public List<Provincia> GetProvincias()
        {

            List<Provincia> lista = new List<Provincia>();//aca

            try
            {
                string cadenaComando = "SELECT ProvinciaId, NombreProvincia FROM Provincias";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Provincia provincia = ConstruirProvincia(reader);// cuando me construye el pais
                    lista.Add(provincia);// se lo pongo a la lista
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer las provincias");
            }
        }

        private Provincia ConstruirProvincia(SqlDataReader reader)
        {
            return new Provincia
            {
                ProvinciaId = reader.GetInt32(0),
                NombreProvincia = reader.GetString(1)
            };
        }

        public void Guardar(Provincia provincia)
        {
            if (provincia.ProvinciaId==0)
            {
                //registro nuevo 
                try
                {
                    string cadenaComando = "INSERT INTO Provincias VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);

                    provincia.ProvinciaId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar el registro");
                }
            }
            else
            {
                try
                {
                    string cadenaComando = "UPDATE Provincias SET NombreProvincia=@localidad WHERE ProvinciaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@localidad", provincia.NombreProvincia);
                    comando.Parameters.AddWithValue("@id", provincia.ProvinciaId);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar el registro");
                }
            }
        }
    }
}
