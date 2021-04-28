using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios
{
    public class RepositorioLocalidades : IRepositorioLocalidades
    {
        private readonly SqlConnection _sqlConnection;
        private readonly IRepositorioProvincias _repositorioProvincias;

        public RepositorioLocalidades(SqlConnection sqlConnection, IRepositorioProvincias repositorioProvincias)
        {
            _sqlConnection = sqlConnection;
            _repositorioProvincias = repositorioProvincias;

        }

        public RepositorioLocalidades(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void Borrar(int id)//BORRAR
        {
            try
            {
                string cadenaComando = "DELETE FROM Localidades WHERE LocalidadId=@id";
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

        public bool Existe(Localidad localidad)//EXISTE
        {
            try
            {
                if (localidad.LocalidadId==0)
                {
                    string cadenaComando = "SELECT * FROM Localidades WHERE NombreLocalidad=@nomb AND ProvinciaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@id", localidad.provincia.ProvinciaId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else
                {
                    string cadenaComando = "SELECT * FROM Localidades WHERE NombreLocalidad=@nomb AND ProvinciaId=@id AND LocalidadId<>@localidadId";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nomb", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@id", localidad.provincia.ProvinciaId);
                    comando.Parameters.AddWithValue("@localidadId", localidad.LocalidadId);
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;

                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<LocalidadListDto> GetLista(Provincia provincia)
        {
            List<LocalidadListDto> lista = new List<LocalidadListDto>();
            try
            {
                string cadenaComando;
                SqlCommand comando;
                SqlDataReader reader;

                if (provincia== null)
                {
                     cadenaComando = "SELECT LocalidadId, NombreLocalidad, " +
                    "NombreProvincia FROM localidades inner join Provincias on " +
                    "localidades.ProvinciaId=Provincias.ProvinciaId";
                     comando = new SqlCommand(cadenaComando, _sqlConnection);
                     reader = comando.ExecuteReader();
                }
                else
                {
                    cadenaComando = "SELECT LocalidadId, NombreLocalidad, " +
                        "NombreProvincia FROM localidades inner join Provincias on " +
                        "localidades.ProvinciaId=Provincias.ProvinciaId " +
                        "WHERE Localidades.ProvinciaId=@provinciaId";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@provinciaId", provincia.ProvinciaId);
                    reader = comando.ExecuteReader();

                }

                while (reader.Read())
                {
                    var localidadDto = ConstruirLocalidadDto(reader);
                    lista.Add(localidadDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Error al intentar leer las localidades");
            }

        }

        public LocalidadEditDto GetLocalidadPorId(int id)
        {
            LocalidadEditDto localidad = null;
            try
            {
                string cadenaComando =
                    "SELECT LocalidadId, NombreLocalidad, ProvinciaId FROM Localidades WHERE LocalidadId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    localidad = ConstruirLocalidad(reader);
                }
                reader.Close();
                return localidad;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer las ciudades");
            }
        }

        private LocalidadEditDto ConstruirLocalidad(SqlDataReader reader)
        {
            var localidad = new LocalidadEditDto();
            localidad.LocalidadId = reader.GetInt32(0);
            localidad.NombreLocalidad = reader.GetString(1);
            localidad.ProvinciaId = reader.GetInt32(2);
            return localidad;
        }

        public void Guardar(Localidad localidad)
        {
            if (localidad.LocalidadId == 0)
            {
                //Nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO Localidades VALUES(@nombrelocalidad, @provinciaId)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombrelocalidad", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@provinciaId", localidad.provincia.ProvinciaId);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    localidad.LocalidadId = (int)(decimal)comando.ExecuteScalar();

                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar ingresar un registro");
                }

            }
            else
            {
                //Edición
                try
                {
                    string cadenaComando = "UPDATE Localidades SET NombreLocalidad=@nombrelocalidad, ProvinciaId=@provinciaId WHERE LocalidadId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombrelocalidad", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@provinciaId", localidad.provincia.ProvinciaId);

                    comando.Parameters.AddWithValue("@id", localidad.LocalidadId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar editar un registro");
                }

            }



        }

        private LocalidadListDto ConstruirLocalidadDto(SqlDataReader reader)
        {
            LocalidadListDto localidadListDto = new LocalidadListDto();
            localidadListDto.LocalidadId = reader.GetInt32(0);
            localidadListDto.NombreLocalidad = reader.GetString(1);
            localidadListDto.NombreProvincia = reader.GetString(2);
            return localidadListDto;
        }

        public Provincia GetProvinciaPorId(int v)
        {
            throw new NotImplementedException();
        }

       
    }
}
