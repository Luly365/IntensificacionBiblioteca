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

        public bool Existe(Genero genero)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioGeneros(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(genero);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Genero GetGeneroPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> GetGeneros()
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

        public void Guardar(Genero genero)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioGeneros(_conexionBd.AbrirConexion());
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
