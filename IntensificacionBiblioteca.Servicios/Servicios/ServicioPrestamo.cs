using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Prestamo;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServicioPrestamo : IServicioPrestamos
    {
        private ConexionBd _conexionBd;
        private IRepositorioPrestamos _repositorio;
        private IRepositorioDetallePrestamos _repositorioDetalle;
        private IRepositorioLibros _repositorioLibros;

        public List<PrestamoListDto> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioDetalle = new RepositorioDetallePrestamos(_conexionBd.AbrirConexion());
                _repositorio = new RepositorioPrestamos(_conexionBd.AbrirConexion(), _repositorioDetalle);
                var lista = _repositorio.GetLista();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
          
        }

        public List<DetallePrestamoListDto> GetDetalle(int detalleDtoPrestamoId)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioDetalle = new RepositorioDetallePrestamos(_conexionBd.AbrirConexion());
                var lista = _repositorioDetalle.GetLista(detalleDtoPrestamoId);
                _conexionBd.CerrarConexion();
                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        

        public PrestamoEditDto GetPrestamoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(PrestamoEditDto prestamoDto)
        {
            throw new NotImplementedException();
        }
    }
}
