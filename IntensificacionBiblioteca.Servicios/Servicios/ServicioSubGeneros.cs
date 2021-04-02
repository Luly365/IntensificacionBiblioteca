using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServicioSubGeneros : IServiciosSubGeneros
    {
        private ConexionBd _conexionBd;
        private IRepositorioSubGenero _repositorio;
        private IRepositorioGeneros _repositorioGeneros;

        public ServicioSubGeneros()
        {
            
        }

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioSubGeneros(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(SubGenero subGenero)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioSubGeneros(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(subGenero);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar ver si existe un SubGenero");
            }
        }

        public List<SubGeneroListDto> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioSubGeneros(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexionBd.CerrarConexion();
                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SubGenero GetSubGeneroPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioGeneros = new RepositorioGeneros(_conexionBd.AbrirConexion());
                _repositorio = new RepositorioSubGeneros(_conexionBd.AbrirConexion(), _repositorioGeneros);
                var subGenero = _repositorio.GetSubGeneroPorId(id);
                _conexionBd.CerrarConexion();
                return subGenero;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(SubGenero subGenero)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioSubGeneros(_conexionBd.AbrirConexion());
                _repositorio.Guardar(subGenero);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
