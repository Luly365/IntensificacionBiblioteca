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
            throw new NotImplementedException();
        }

        public bool Existe(Provincia provincia)
        {
            throw new NotImplementedException();
        }

        public Provincia GetProvinciaPorId(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
