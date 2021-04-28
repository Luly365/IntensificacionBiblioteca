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
        private IRepositorioProvincias _repositorioProvincia;

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

        public bool Existe(LocalidadEditDto localidadDto)
        {// yo recibo una 'localidadDto" aqui pero la tengo que
         //transformar en 1 "localidad"
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                _repositorioProvincia = new RepositorioProvincias(_conexionBd.AbrirConexion());
                var localidad = new Localidad
                {
                    //le paso los datos de la locDto a loc 
                    LocalidadId = localidadDto.LocalidadId,
                    NombreLocalidad=localidadDto.NombreLocalidad,
                    provincia=_repositorioProvincia.GetProvinciaPorId(localidadDto.ProvinciaId)
                };
                //se lo paso al repositorio y me fijo si existe
                var existe = _repositorio.Existe(localidad);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar ver si existe la Localidad");
            }
        }

        public List<LocalidadListDto> GetLista(Provincia provincia)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista(provincia);
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        //public List<LocalidadListDto> GetLista(Provincia provincia)
        //{
        //    throw new NotImplementedException();
        //}

        public LocalidadEditDto GetLocalidadPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioProvincia = new RepositorioProvincias(_conexionBd.AbrirConexion());
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion(), _repositorioProvincia);
                var ciudad = _repositorio.GetLocalidadPorId(id);
                _conexionBd.CerrarConexion();
                return ciudad;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(LocalidadEditDto localidadDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                _repositorioProvincia = new RepositorioProvincias(_conexionBd.AbrirConexion());
                var localidad = new Localidad
                { 
                    LocalidadId = localidadDto.LocalidadId,
                    NombreLocalidad = localidadDto.NombreLocalidad,
                    provincia = _repositorioProvincia.GetProvinciaPorId(localidadDto.ProvinciaId)
                };
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
    

