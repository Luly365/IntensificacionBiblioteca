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
            throw new NotImplementedException();
        }

        public bool Existe(TipoDeDocumento tipoDeDocumento)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
