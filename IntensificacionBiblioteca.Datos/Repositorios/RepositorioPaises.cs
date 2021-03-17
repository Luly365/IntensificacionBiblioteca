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
            throw new NotImplementedException();
        }

        public bool Existe(Pais pais)
        {
            throw new NotImplementedException();
        }

        public Pais GetPaisPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Pais pais)
        {
            throw new NotImplementedException();
        }
    }
}
