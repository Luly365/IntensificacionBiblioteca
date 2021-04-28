using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades;
using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioDetallePrestamos : IRepositorioDetallePrestamos
    {
        private readonly SqlConnection _sqlConnection;
        private SqlTransaction _tran;
        public RepositorioDetallePrestamos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public RepositorioDetallePrestamos(SqlConnection sqlConnection, SqlTransaction tran) : this(sqlConnection)
        {
            this._tran = tran;
        }

        public List<DetallePrestamoListDto> GetLista(int prestamoId)
        {
            List<DetallePrestamoListDto> lista = new List<DetallePrestamoListDto>();
            try
            {
                string cadenaComando = "SELECT DetallePrestamoId, Titulo, ISBN, Observaciones" +
                    " FROM DetallesPrestamos INNER JOIN Libros ON DetallesPrestamos.LibroId = Libros.LibroId " +
                    " WHERE PrestamoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
               comando.Parameters.AddWithValue("@id", prestamoId);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var detalleListDto = ConstruirDetalleListDto(reader);
                    lista.Add(detalleListDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private DetallePrestamoListDto ConstruirDetalleListDto(SqlDataReader reader)
        {
            DetallePrestamoListDto detalleDto= new DetallePrestamoListDto();

            detalleDto.DetallePrestamoId = reader.GetInt32(0);
            detalleDto.Titulo = reader.GetString(1);
            detalleDto.ISBN = reader.GetString(2);
            detalleDto.Observaciones = reader.GetString(3);
            return detalleDto;
        }

        public void Guardar(DetallePrestamo detalle)
        {
            throw new NotImplementedException();
        }

    
    }
}
