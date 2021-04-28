using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Estado;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServiciosEstado : IServiciosEstado
    {

        private IRepositorioEstados _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosEstado()
        {

        }

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(EstadoEditDto estadoDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                var estado = new Estado
                {
                    EstadoId= estadoDto.EstadoId,
                    Descripcion=estadoDto.Descripcion
                };

                var existe = _repositorio.Existe(estado);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public EstadoEditDto GetEstadoPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                var estado = _repositorio.GetEstadoPorId(id);
                _conexionBd.CerrarConexion();
                return estado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<EstadoListDto> GetEstados()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetEstados();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(EstadoEditDto estadoDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                var estado = new Estado
                {
                    EstadoId = estadoDto.EstadoId,
                    Descripcion = estadoDto.Descripcion
                };

                _repositorio.Guardar(estado);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
