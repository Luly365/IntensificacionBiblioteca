using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Prestamo;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            var listaDetalles = new List<DetallePrestamo>();
            foreach (var itemDto in prestamoDto.DetallePrestamo)//falta validar los datos del socio
            {
                var item = new DetallePrestamo()
                {
                    DetallePedidoId=itemDto.DetallePrestamoId,
                    Libro= new Libro
                    {
                        LibroId=itemDto.Libro.LibroId,
                        Titulo=itemDto.Libro.Titulo
                    },
                    //cantidad = itemDto.Cantidad
                    cantidad=1


                };
                listaDetalles.Add(item);
            }

            var prestamo = new Prestamo
            {
                PrestamoId = prestamoDto.PrestamoId,
                Socio = new Socio
                {
                    SocioId=prestamoDto.NombreSocio.SocioId,
                    NroDoc=prestamoDto.NombreSocio.NroDoc
                },
                FechaPrestamo=prestamoDto.FechaPrestamo,
                detallePrestamo=listaDetalles
               
            };

            _conexionBd = new ConexionBd();
            SqlTransaction tran = null;

            try
            {
                SqlConnection cn = _conexionBd.AbrirConexion();
                tran = cn.BeginTransaction();//Comienza la transacción
                _repositorio = new RepositorioPrestamos(cn, tran);
                _repositorioLibros = new RepositorioLibros(cn, tran);
                _repositorioDetalle = new RepositorioDetallePrestamos(cn, tran);
                _repositorio.Guardar(prestamo);//sigue deberia irse a guardar
                
                foreach (var detallePrestamo in prestamo.detallePrestamo)
                {
                    detallePrestamo.Prestamo = prestamo;
                    _repositorioDetalle.Guardar(detallePrestamo);
                    _repositorioLibros.ActualizarPrestamos(detallePrestamo.Libro,
                        -detallePrestamo.cantidad);
                }
                tran.Commit();//persiste los datos
                prestamoDto.PrestamoId = prestamo.PrestamoId;

            }
            catch (Exception e)
            {

                tran.Rollback();
                throw new Exception(e.Message);
            }

        }
    }
}
