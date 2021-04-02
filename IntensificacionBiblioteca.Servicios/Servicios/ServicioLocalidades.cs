using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServicioLocalidades : IServicioLocalidades
    {
        private ConexionBd _conexionBd;
        private IRepositorioLocalidades _repositorio;
        private IRepositorioProvincias _repositorioprovincia;

        public ServicioLocalidades()
        {

        }

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Localidad localidad)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(localidad);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar ver si existe la Localidad");
            }
        }

        public List<LocalidadListDto> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Localidad GetLocalidadPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioprovincia = new RepositorioProvincias(_conexionBd.AbrirConexion());
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion(), _repositorioprovincia);
                var ciudad = _repositorio.GetLocalidadPorId(id);
                _conexionBd.CerrarConexion();
                return ciudad;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Localidad localidad)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                _repositorio.Guardar(localidad);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            

        }
            
    }
}
    

