using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.DTOs.Estado;
using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.DTOs.Libro;
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
    public class RepositorioLibros : IRepositorioLibros
    {
        private readonly SqlConnection _sqlConnection;
        private SqlTransaction _tran;
        private readonly IRepositorioPaises _repositorioPaises;
        private readonly IRepositorioEditoriales _repositorioEditoriales;

        private readonly IRepositorioGeneros _repositorioGenero;
        private readonly IRepositorioSubGenero _repositorioSubGenero;
        private readonly IRepositorioEstados _repositorioEstados;

        public RepositorioLibros(SqlConnection sqlConnection, IRepositorioPaises repositorioPaises,
            IRepositorioEditoriales repositorioEditoriales,//IRepositorioPaises repositorioPaises
            IRepositorioGeneros repositorioGenero,
            IRepositorioSubGenero repositorioSubGenero, IRepositorioEstados repositorioEstados)
        {
            _sqlConnection = sqlConnection;
            _repositorioPaises = repositorioPaises;
            _repositorioEditoriales = repositorioEditoriales;

            _repositorioGenero = repositorioGenero;
            _repositorioSubGenero = repositorioSubGenero;
            _repositorioEstados = repositorioEstados;
        }

        public RepositorioLibros(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public RepositorioLibros(SqlConnection sqlConnection, SqlTransaction tran) : this(sqlConnection)
        {
            this._tran = tran;
        }

        public bool Existe(Libro libro)
        {
            try
            {
                if (libro.LibroId == 0)
                {
                    string cadenaComando = "SELECT * FROM Libros WHERE Titulo=@nomb";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", libro.Titulo);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else
                {
                    string cadenaComando = "SELECT * FROM Libros WHERE Titulo=@nomb AND LibroId<>@LibroId";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", libro.Titulo);
                    comando.Parameters.AddWithValue("@LibroId", libro.LibroId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;

                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<LibroListDto> GetLista()//puede sobrecarcarse 
        {
            List<LibroListDto> lista = new List<LibroListDto>();
            try
            {
                string cadenaComando =
                    "SELECT LibroId, Titulo, ISBN, e.NombreEditorial, g.Descripcion, sg.Descripcion," +
                    " FechaIncorporacion, es.Descripcion, Observaciones, Disponible, Stock FROM " +
                    "Generos g JOIN SubGeneros sg on g.GeneroId = sg.GeneroId JOIN " +
                    "Libros l on sg.SubGeneroId = l.SubGeneroId JOIN Editoriales e on " +
                    "l.EditorialId = e.EditorialId JOIN Estados es on es.EstadoId = l.EstadoId";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var libroListDto = ConstruirLibroListDto(reader);
                    lista.Add(libroListDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Libros");
            }
        }

        public void Guardar(Libro libro)
        {
            if (libro.LibroId == 0)
            {
                //Nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO Libros VALUES(@titulo, @Isbn, @editorialId, @generoId," +
                        " @subGeneroId, @fecha, @estadoId, @observ, @disponible, @stock)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@titulo", libro.Titulo);
                    comando.Parameters.AddWithValue("@Isbn", libro.ISBN);
                    comando.Parameters.AddWithValue("@editorialId", libro.Editorial.EditorialId);
                    comando.Parameters.AddWithValue("@generoId", libro.Genero.GeneroId);
                    comando.Parameters.AddWithValue("@subGeneroId", libro.SubGenero.SubGeneroId);
                    comando.Parameters.AddWithValue("@fecha", libro.FechaIncorporacion);
                    comando.Parameters.AddWithValue("@estadoId", libro.Estado.EstadoId);
                    //pero observaciones puede ser nulo por lo tanto tenemos que aclararle que si no es nulo, haga:
                    if (libro.Observaciones != string.Empty)
                    {
                        comando.Parameters.AddWithValue("@observ", libro.Observaciones);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@observ", DBNull.Value);
                    }

                    comando.Parameters.AddWithValue("@disponible", libro.Disponible);

                    comando.Parameters.AddWithValue("@stock", libro.Stock);



                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    libro.LibroId = (int)(decimal)comando.ExecuteScalar();

                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar Guardar un Libro");
                }

            }
            else
            {
                //Edición
                try
                {
                    string cadenaComando = "UPDATE Libros SET Titulo=@titulo, ISBN=@Isbn, EditorialId=@editorialId," +
                                           " GeneroId=@generoId, SubGeneroId=@subGeneroId, fechaIncorporacion=@fecha," +
                                           "EstadoId=@estadoId, Observaciones=@observ, Disponible=@disponible, Stock=@stock WHERE LibroId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);

                    comando.Parameters.AddWithValue("@titulo", libro.Titulo);
                    comando.Parameters.AddWithValue("@Isbn", libro.ISBN);
                    comando.Parameters.AddWithValue("@editorialId", libro.Editorial.EditorialId);
                    comando.Parameters.AddWithValue("@generoId", libro.Genero.GeneroId);
                    comando.Parameters.AddWithValue("@subGeneroId", libro.SubGenero.SubGeneroId);
                    comando.Parameters.AddWithValue("@fecha", libro.FechaIncorporacion);
                    comando.Parameters.AddWithValue("@estadoId", libro.Estado.EstadoId);
                    //pero observaciones puede ser nulo por lo tanto tenemos que aclararle que si no es nulo, haga:
                    if (libro.Observaciones != string.Empty)
                    {
                        comando.Parameters.AddWithValue("@observ", libro.Observaciones);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@observ", DBNull.Value);
                    }
                    comando.Parameters.AddWithValue("@disponible", libro.Disponible);
                    comando.Parameters.AddWithValue("@stock", libro.Stock);

                    comando.Parameters.AddWithValue("@id", libro.LibroId);

                    comando.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar editar un Libro");
                }

            }
        }

        private LibroListDto ConstruirLibroListDto(SqlDataReader reader)
        {
            LibroListDto libro = new LibroListDto();

            libro.LibroId = reader.GetInt32(0);
            libro.Titulo = reader.GetString(1);
            libro.ISBN = reader.GetString(2);
            libro.Editorial = reader.GetString(3);
            libro.NombreGenero = reader.GetString(4);
            libro.NombreSubGenero = reader.GetString(5);
            libro.FechaIncorporacion = reader.GetDateTime(6);
            libro.DescripcionEstado = reader.GetString(7);
            libro.Observaciones = reader[8] != DBNull.Value ? reader.GetString(8) : null;
            libro.Disponible = reader.GetBoolean(9);
            libro.Stock = reader.GetInt32(10);
            return libro;

        }

        public LibroEditDto GetLibroPorId(int libroId)
        {
            LibroEditDto libro = null;
            try
            {
                string cadenaComando = "SELECT LibroId, Titulo, ISBN, EditorialId, GeneroId, " +
                    "SubGeneroId, FechaIncorporacion, EstadoId, Observaciones, Disponible, Stock " +
                    "FROM Libros WHERE LibroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", libroId);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    libro = ConstruirLibroEditDto(reader);
                }
                reader.Close();
                return libro;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer el libro");
            }
        }

        private LibroEditDto ConstruirLibroEditDto(SqlDataReader reader)
        {

            var libro = new LibroEditDto();
            libro.LibroId = reader.GetInt32(0);
            libro.Titulo = reader.GetString(1);
            libro.ISBN = reader.GetString(2);
            var EditorialEditDto = _repositorioEditoriales.GetEditorialPorId(reader.GetInt32(3));
            libro.Editorial = new EditorialListDto
            {
                EditorialId = EditorialEditDto.EditorialId,
                NombreEditorial = EditorialEditDto.NombreEditorial,
                NombrePais = EditorialEditDto.Pais.NombrePais

            };
            var generoEditDto = _repositorioGenero.GetGeneroPorId(reader.GetInt32(4));
            libro.Genero = new GeneroListDto
            {
                GeneroId = generoEditDto.GeneroId,
                Descripcion = generoEditDto.Descripcion
            };
            var subGeneroEditDto = _repositorioSubGenero.GetSubGeneroPorId(reader.GetInt32(5));
            libro.SubGenero = new SubGeneroListDto
            {
                SubGeneroId = subGeneroEditDto.SubGeneroId,
                NombreSubGenero = subGeneroEditDto.NombreSubGenero,
                NombreGenero = subGeneroEditDto.Genero.Descripcion,
            };
            libro.FechaIncorporacion = reader.GetDateTime(6);
            var estadoEditDto = _repositorioEstados.GetEstadoPorId(reader.GetInt32(7));
            libro.Estado = new EstadoListDto
            {
                EstadoId = estadoEditDto.EstadoId,
                Descripcion = estadoEditDto.Descripcion
            };
            libro.Observaciones = reader[8] != DBNull.Value ? reader.GetString(8) : string.Empty;

            libro.Disponible = reader.GetBoolean(9);// boleanoooo check 

            libro.Stock = reader.GetInt32(10);

            return libro;
        }

        public void Borrar(int libroId)
        {
            try
            {
                string cadenaComando = "DELETE FROM Libros WHERE LibroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", libroId);
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

        public void ActualizarPrestamos(Libro libro, int cantidad)
        {
            
            try
            {
                string cadenaComando = "UPDATE Libros SET Stock=Stock+@cant WHERE LibroId=@id";
                var comando = new SqlCommand(cadenaComando, _sqlConnection, _tran);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@id", libro.LibroId);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Error al actualizar el stock de un Libro");
            }


        }
    }
}
