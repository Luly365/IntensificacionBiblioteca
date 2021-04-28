using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.DTOs.Pais;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioEditoriales : IRepositorioEditoriales
    {
        private readonly SqlConnection _sqlConnection;
        private readonly IRepositorioPaises _repositorioPaises;
        public RepositorioEditoriales(SqlConnection sqlConnection, IRepositorioPaises repositorioPaises)
        {
            _sqlConnection = sqlConnection;
            _repositorioPaises = repositorioPaises;
        }

        public RepositorioEditoriales(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Editoriales WHERE EditorialId=@id";
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

        public bool Existe(Editorial editorial)
        {
            try
            {
                if (editorial.EditorialId == 0)
                {
                    string cadenaComando = "SELECT * FROM Editoriales WHERE NombreEditorial=@nomb AND PaisId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", editorial.NombreEditorial);
                    comando.Parameters.AddWithValue("@id", editorial.Pais.PaisId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else
                {
                    string cadenaComando = "SELECT * FROM Editoriales WHERE NombreEditorial=@nomb AND PaisId=@id AND EditorialId<>@editorialId";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", editorial.NombreEditorial);
                    comando.Parameters.AddWithValue("@id", editorial.Pais.PaisId);
                    comando.Parameters.AddWithValue("@editorialId", editorial.EditorialId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;

                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public EditorialEditDto GetEditorialPorId(int id)
        {
            EditorialEditDto editorial = null;
            try
            {
                string cadenaComando =
                    "SELECT EditorialId, NombreEditorial, PaisId FROM Editoriales WHERE EditorialId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    editorial = ConstruirEditorial(reader);
                }
                reader.Close();
                return editorial;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer las Editoriales");
            }
        }

        private EditorialEditDto ConstruirEditorial(SqlDataReader reader)
        {
            var editorial = new EditorialEditDto();
            editorial.EditorialId = reader.GetInt32(0);
            editorial.NombreEditorial = reader.GetString(1);
            
            var paisEditDto = _repositorioPaises.GetPaisPorId(reader.GetInt32(2));
            editorial.Pais = new PaisListDto
            {
                PaisId = paisEditDto.PaisId,
                NombrePais = paisEditDto.NombrePais
            };
            return editorial;
        }

        public List<EditorialListDto> GetLista(PaisListDto paisDto)
        {
            List<EditorialListDto> lista = new List<EditorialListDto>();

            try
            {
                string cadenaComando;
                SqlCommand comando;
                SqlDataReader reader;
                if (paisDto==null)
                {
                     cadenaComando = "SELECT EditorialId, NombreEditorial, NombrePais " +
                    "FROM Editoriales inner join Paises on Editoriales.PaisId=Paises.PaisId";
                     comando = new SqlCommand(cadenaComando, _sqlConnection);
                     reader = comando.ExecuteReader();
                }
                else
                {
                    cadenaComando = "SELECT EditorialId, NombreEditorial, NombrePais " +
                    "FROM Editoriales inner join Paises on Editoriales.PaisId=Paises.PaisId" +
                    " WHERE Editoriales.PaisId=@paisId";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@paisId", paisDto.PaisId);
                    reader = comando.ExecuteReader();
                }
                while (reader.Read())
                {
                    var editorialDto = ConstruirEditorialDto(reader);//ConstruirEditorialDto
                    lista.Add(editorialDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer las Editoriales");
            }

        }

        public void Guardar(Editorial editorial)
        {
            if (editorial.EditorialId == 0)
            {
                //Nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO Editoriales VALUES(@nombre, @paisId)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", editorial.NombreEditorial);
                    comando.Parameters.AddWithValue("@paisId", editorial.Pais.PaisId);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    editorial.EditorialId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar Guardar un registro.");
                }
            }
            else
            {
                //Edición
                try
                {
                    string cadenaComando = "UPDATE Editoriales SET NombreEditorial=@nombre, PaisId=@paisId WHERE EditorialId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", editorial.NombreEditorial);
                    comando.Parameters.AddWithValue("@paisId", editorial.Pais.PaisId);
                    comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar Editar un Registro.");
                }

            }
        }

        private EditorialListDto ConstruirEditorialDto(SqlDataReader reader)
        {
            EditorialListDto editorialDto = new EditorialListDto();
            editorialDto.EditorialId = reader.GetInt32(0);
            editorialDto.NombreEditorial = reader.GetString(1);
            editorialDto.NombrePais = reader.GetString(2);//editorialDto.Pais.NombrePais = reader.GetString(2);
            return editorialDto;
        }
    }
}
