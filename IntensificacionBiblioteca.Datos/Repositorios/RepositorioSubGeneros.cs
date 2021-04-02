using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioSubGeneros : IRepositorioSubGenero
    {
        private readonly SqlConnection _sqlConnection;
        private readonly IRepositorioGeneros _repositorioGenero;
        public RepositorioSubGeneros(SqlConnection sqlConnection, IRepositorioGeneros repositorioGenero)
        {
            _sqlConnection = sqlConnection;
            _repositorioGenero = repositorioGenero;
        }

        public RepositorioSubGeneros(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM SubGeneros WHERE SubGeneroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
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

        public bool Existe(SubGenero subGenero)
        {
            try
            {
                if (subGenero.SubGeneroId == 0)//se Agrega
                {
                    string cadenaComando = "SELECT * FROM SubGeneros WHERE Descripcion=@nomb AND GeneroId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", subGenero.NombreSubGenero);
                    comando.Parameters.AddWithValue("@id", subGenero.genero.GeneroId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else//si no es cero, se Edita
                {
                    string cadenaComando = "SELECT * FROM SubGeneros WHERE Descripcion=@nomb AND GeneroId=@id AND SubGeneroId<>@subGeneroId";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", subGenero.NombreSubGenero);
                    comando.Parameters.AddWithValue("@id", subGenero.genero.GeneroId);
                    comando.Parameters.AddWithValue("@subGeneroId", subGenero.SubGeneroId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;

                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<SubGeneroListDto> GetLista()
        {
            
            List<SubGeneroListDto> lista = new List<SubGeneroListDto>();
            try
            {
                string cadenaComando =
                    "SELECT SubGeneroId, SG.Descripcion, G.Descripcion " +
                    "FROM SubGeneros SG INNER JOIN Generos G on SG.GeneroId=G.GeneroId";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var subGeneroDto = ConstruirSubGeneroDto(reader);
                    lista.Add(subGeneroDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los SubGeneros");
            }
        }

        private SubGeneroListDto ConstruirSubGeneroDto(SqlDataReader reader)
        {
            SubGeneroListDto subGeneroDto = new SubGeneroListDto();
            subGeneroDto.SubGeneroId = reader.GetInt32(0);
            subGeneroDto.NombreSubGenero = reader.GetString(1);
            subGeneroDto.NombreGenero = reader.GetString(2);
            return subGeneroDto;
        }

        public SubGenero GetSubGeneroPorId(int id)
        {
            SubGenero subGenero = null;
            try
            {
                string cadenaComando =
                    "SELECT SubGeneroId, Descripcion, GeneroId FROM SubGeneros WHERE SubGeneroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    subGenero = ConstruirSubGenero(reader);
                }
                reader.Close();
                return subGenero;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer las ciudades");
            }
        }

        private SubGenero ConstruirSubGenero(SqlDataReader reader)
        {
            SubGenero subGenero = new SubGenero();
            subGenero.SubGeneroId = reader.GetInt32(0);
            subGenero.NombreSubGenero = reader.GetString(1);
            subGenero.genero = _repositorioGenero.GetGeneroPorId(reader.GetInt32(2));
            return subGenero;
        }

        public void Guardar(SubGenero subGenero)
        {
            if (subGenero.SubGeneroId == 0)
            {
                //Nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO SubGeneros VALUES(@nombreSubGenero, @generoId)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombreSubGenero", subGenero.NombreSubGenero);
                    comando.Parameters.AddWithValue("@generoId", subGenero.genero.GeneroId);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    subGenero.SubGeneroId = (int)(decimal)comando.ExecuteScalar();

                }
                catch (Exception)
                {
                    throw new Exception("Error al Intentar Guardar el Registro.");
                }

            }
            else
            {
                //Edición
                try
                {
                    string cadenaComando = "UPDATE SubGeneros SET Descripcion=@nombreSubGenero, " +
                        "GeneroId=@generoId WHERE SubGeneroId=@Id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombreSubGenero", subGenero.NombreSubGenero);
                    comando.Parameters.AddWithValue("@generoId", subGenero.genero.GeneroId);
                    comando.Parameters.AddWithValue("@id", subGenero.SubGeneroId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw new Exception("Error al Intentar Editar el Registro.");
                }

            }
        }
    }
}
