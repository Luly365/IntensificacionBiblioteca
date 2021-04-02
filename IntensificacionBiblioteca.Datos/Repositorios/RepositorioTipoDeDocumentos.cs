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
    public class RepositorioTipoDeDocumentos : IRepositorioTipoDeDocumentos
    {
        private readonly SqlConnection _conexion;

        public RepositorioTipoDeDocumentos(SqlConnection conexion)
        {
            _conexion = conexion;
        }
        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM TiposDeDocumentos WHERE TipoDeDocId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    throw new Exception("Registro con datos relacionados... Baja denegada");
                }
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeDocumento tipoDeDocumento)
        {
            if (tipoDeDocumento.TipoDeDocId == 0)
            {
                string cadenaComando = "SELECT TipoDeDocId, Descripcion FROM TiposDeDocumentos WHERE Descripcion=@descripcion";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@descripcion", tipoDeDocumento.Descripcion);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;

            }
            else
            {
                var cadenaComando = "SELECT TipoDeDocId, Descripcion FROM TiposDeDocumentos WHERE Descripcion=@descripcion AND TipoDeDocId<>@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@descripcion", tipoDeDocumento.Descripcion);
                comando.Parameters.AddWithValue("@id", tipoDeDocumento.TipoDeDocId);
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }

            
        }
        
        public List<TipoDeDocumento> GetTipoDeDoc()
        {
            List<TipoDeDocumento> lista = new List<TipoDeDocumento>();
            try
            {
                string cadenaComando = "SELECT TipoDeDocId, Descripcion FROM TiposDeDocumentos";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TipoDeDocumento tipoDeDoc = ConstruirTipoDeDoc(reader);
                    lista.Add(tipoDeDoc);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar leer los Tipos de Documentos");
            }
        }

        private TipoDeDocumento ConstruirTipoDeDoc(SqlDataReader reader)
        {
            return new TipoDeDocumento
            {
                TipoDeDocId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public TipoDeDocumento GetTipoDeDocPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TipoDeDocumento tipoDeDocumento)
        {
            if (tipoDeDocumento.TipoDeDocId==0)
            {
                //nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO TiposDeDocumentos VALUES (@Descripcion)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@Descripcion", tipoDeDocumento.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _conexion);

                    tipoDeDocumento.TipoDeDocId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw new Exception("Error al intentar guardar el registro.");
                }
                
            }
            else
            {//editar
                try
                {
                    string cadenaComando = "UPDATE TiposDeDocumentos SET Descripcion=@descripcion WHERE TipoDeDocId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@descripcion", tipoDeDocumento.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipoDeDocumento.TipoDeDocId);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Error al intentar guardar el registro.");
                }
            }
        }
    }
}
