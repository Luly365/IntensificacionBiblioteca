using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Prestamo;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioPrestamos : IRepositorioPrestamos
    {

        private readonly SqlConnection _sqlConnection;
        private SqlTransaction tran;
        private readonly IRepositorioDetallePrestamos _repositorioDetalles;

        public RepositorioPrestamos(SqlConnection sqlConnection, IRepositorioDetallePrestamos repositorioDetalles)
        {
            _sqlConnection = sqlConnection;
            _repositorioDetalles = repositorioDetalles;
        }

        public RepositorioPrestamos(SqlConnection sqlConnection)
        {
            this._sqlConnection = sqlConnection;
        }

        public RepositorioPrestamos(SqlConnection sqlConnection, SqlTransaction tran) : this(sqlConnection)
        {
            this.tran = tran;
        }

        public List<PrestamoListDto> GetLista()
        {
            List<PrestamoListDto> lista = new List<PrestamoListDto>();
            try
            {
                string cadenaComando =
                    "SELECT PrestamoId, Nombre, Apellido, FechaPrestamo " +
                    " FROM Socios INNER JOIN Prestamos ON socios.SocioId=Prestamos.SocioId";

                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var prestamoListDto = ConstruirPrestamoListDto(reader);
                    lista.Add(prestamoListDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al Intentar Leer los Prestamos");
            }
        }

        private PrestamoListDto ConstruirPrestamoListDto(SqlDataReader reader)
        {

            PrestamoListDto prestamoDto = new PrestamoListDto();
            prestamoDto.PrestamoId = reader.GetInt32(0);
            prestamoDto.NombreSocio = reader.GetString(1);
            prestamoDto.ApellidoSocio = reader.GetString(2);
            prestamoDto.FechaPrestamo = reader.GetDateTime(3);
            prestamoDto.ItemsPrestamo = _repositorioDetalles.GetLista(reader.GetInt32(0));
            //si anda mal puede ser esto de aca 1 renglon arriba

            return prestamoDto;

        }

        public PrestamoEditDto GetPrestamoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Prestamo prestamo)
        {
            try
            {
                string cadenaComando = "INSERT INTO Prestamos (SocioId, FechaPrestamo) " +
                                       "VALUES (@socioId, @fecha)";
                var comando = new SqlCommand(cadenaComando, _sqlConnection, tran);
                comando.Parameters.AddWithValue("@socioId", prestamo.Socio.SocioId);
                comando.Parameters.AddWithValue("@fecha", prestamo.FechaPrestamo);

                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _sqlConnection, tran);
                int id = (int)(decimal)comando.ExecuteScalar();
                prestamo.PrestamoId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
