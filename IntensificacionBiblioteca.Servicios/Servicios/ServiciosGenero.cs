using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServiciosGenero : IServiciosGenero
    {
        private IRepositorioGeneros _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosGenero()
        {

        }

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioGeneros(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(GeneroEditDto generoDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioGeneros(_conexionBd.AbrirConexion());
                var genero = new Genero
                {
                    GeneroId = generoDto.GeneroId,
                    Descripcion = generoDto.Descripcion,
                };
                var existe = _repositorio.Existe(genero);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public GeneroEditDto GetGeneroPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioGeneros(_conexionBd.AbrirConexion());
                var genero = _repositorio.GetGeneroPorId(id);
                _conexionBd.CerrarConexion();
                return genero;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<GeneroListDto> GetGeneros()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioGeneros(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetGeneros();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(GeneroEditDto generoDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioGeneros(_conexionBd.AbrirConexion());
                var genero = new Genero
                {
                    GeneroId=generoDto.GeneroId,
                    Descripcion=generoDto.Descripcion
                };
                _repositorio.Guardar(genero);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
