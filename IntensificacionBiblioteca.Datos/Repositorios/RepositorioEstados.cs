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
    public class RepositorioEstados : IRepositorioEstados
    {
        private readonly SqlConnection _conexion;

        public RepositorioEstados(SqlConnection conexion)
        {
            _conexion = conexion;
        }
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Estado estado)
        {
            throw new NotImplementedException();
        }

        public Estado GetEstadoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estado> GetEstados()
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                string cadenaComando = "SELECT EstadoId, Descripcion FROM Estados";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estado estado = ConstruirEstado(reader);
                    lista.Add(estado);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Estados");
            }
        }

        private Estado ConstruirEstado(SqlDataReader reader)
        {
            return new Estado
            {
                EstadoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public void Guardar(Estado estado)
        {
            throw new NotImplementedException();
        }
    }
}
