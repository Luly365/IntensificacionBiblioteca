using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Socio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioSocios : IRepositorioSocios
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioSocios(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public List<SocioListDto> GetLista()
        {
            List<SocioListDto> lista = new List<SocioListDto>();
            try
            {
                string cadenaComando =
                    "SELECT SocioId, Nombre, Apellido, NroDoc ,Direccion, l.NombreLocalidad, TelefonoFijo," +
                    " TelefonoMovil, CorreoElectronico, Sancionado, Activo " +
                    "FROM Provincias p JOIN Localidades l on p.ProvinciaId = l.ProvinciaId JOIN " +
                    "Socios s on s.LocalidadId = l.LocalidadId ";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var socioListDto = ConstruirSocioListDto(reader);
                    lista.Add(socioListDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Socios");
            }

        }

        private SocioListDto ConstruirSocioListDto(SqlDataReader reader)
        {
            SocioListDto socio = new SocioListDto();

            socio.SocioId = reader.GetInt32(0);
            socio.Nombre = reader.GetString(1);
            socio.Apellido = reader.GetString(2);
            socio.NroDoc = reader.GetString(3);
            socio.Direccion = reader.GetString(4);
            socio.NombreLocalidad = reader.GetString(5);
            socio.TelefonoFijo = reader[6] != DBNull.Value ? reader.GetString(6) : null;
            socio.TelefonoMovil = reader[7] != DBNull.Value ? reader.GetString(7) : null;
            socio.CorreoElectronico = reader[8] != DBNull.Value ? reader.GetString(8) : null;
            socio.Sancionado = reader.GetBoolean(9);
            socio.Activo = reader.GetBoolean(10);
            return socio;

        }
    }
}
