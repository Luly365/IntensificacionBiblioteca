using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServiciosTipoDeDocumento : IServiciosTipoDeDocumento
    {
        private IRepositorioTipoDeDocumentos _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosTipoDeDocumento()
        {

        }
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TipoDeDocumento tipoDeDocumento)
        {
            throw new NotImplementedException();
        }

        public TipoDeDocumento GetTipoDeDocPorId(int id)
        {
            throw new NotImplementedException();
        }

      

        public List<TipoDeDocumento> GetTipoDeDocumentos()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoDeDocumentos(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetTipoDeDoc();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(TipoDeDocumento tipoDeDocumento)
        {
            throw new NotImplementedException();
        }
    }
}
