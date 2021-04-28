using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Estado;
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
            try
            {
                string cadenaComando = "DELETE FROM Estados WHERE EstadoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    throw new Exception("Registros con datos asociados... Baja denegada");
                }
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Estado estado)
        {
            try
            {
                //SqlCommand comando;
                if (estado.EstadoId == 0)
                {// nuevo estado
                    string cadenaComando = "SELECT EstadoId,Descripcion FROM Estados WHERE Descripcion=@nombre";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else
                {
                    string cadenaComando = "SELECT EstadoId,Descripcion FROM Estados WHERE Descripcion=@nombre AND EstadoId<>@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                    comando.Parameters.AddWithValue("@id", estado.EstadoId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public EstadoEditDto GetEstadoPorId(int id)
        {
            EstadoEditDto estado = null;
            try
            {
                string cadenaComando =
                    "SELECT EstadoId, Descripcion FROM Estados WHERE EstadoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    estado = ConstruirEstadoEditDto(reader);
                }
                reader.Close();
                return estado;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer los estados");
            }
        }

        private EstadoEditDto ConstruirEstadoEditDto(SqlDataReader reader)
        {
            return new EstadoEditDto
            {
                EstadoId= reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public List<EstadoListDto> GetEstados()
        {
            List<EstadoListDto> lista = new List<EstadoListDto>();
            try
            {
                string cadenaComando = "SELECT EstadoId, Descripcion FROM Estados";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    EstadoListDto estado = ConstruirEstadoListDto(reader);
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

        private EstadoListDto ConstruirEstadoListDto(SqlDataReader reader)
        {
            return new EstadoListDto
            {
                EstadoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public void Guardar(Estado estado)
        {
            if (estado.EstadoId == 0) 
            {//Nuevo estado
                try
                {
                    string cadenaComando = "INSERT INTO Estados VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    estado.EstadoId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar un registro");
                }
            }
            else
            {
                try
                {
                    //Editar Estado
                    string cadenaComando = "UPDATE Estados SET Descripcion=@nombre WHERE EstadoId=@id ";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                    comando.Parameters.AddWithValue("@id", estado.EstadoId);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw new Exception("Error al intentar guardar un registro");
                }
            };
        }
    }
}
