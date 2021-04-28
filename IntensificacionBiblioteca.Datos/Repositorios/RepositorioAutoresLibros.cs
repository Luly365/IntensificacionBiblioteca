using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.AutorLibro;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioAutoresLibros : IRepositorioAutoresLibros
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioAutoresLibros(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public List<AutorLibroListDto> GetLista()
        {
            List<AutorLibroListDto> lista = new List<AutorLibroListDto>();
            try
            {
                string cadenaComando =
                    "SELECT AutorLibroId, Titulo, NombreAutor FROM AutoresLibros " +
                    "Au JOIN Autores A On Au.AutorId=A.AutorId JOIN Libros L on " +
                    "L.LibroId=AU.LibroId";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var autorLibroListDto = ConstruirAutorLibroListDto(reader);
                    lista.Add(autorLibroListDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Datos de la tabla Autores/Libros");
            }
        }

        private AutorLibroListDto ConstruirAutorLibroListDto(SqlDataReader reader)
        {
            AutorLibroListDto autorlibro = new AutorLibroListDto();

            autorlibro.AutorLibroId = reader.GetInt32(0);
            autorlibro.Titulo = reader.GetString(1);
            autorlibro.NombreAutor = reader.GetString(2);
            return autorlibro;

        }
    }
}
