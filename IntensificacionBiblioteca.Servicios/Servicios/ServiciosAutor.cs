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
    public class ServiciosAutor : IServiciosAutor
    {
        private IRepositorioAutores _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosAutor()
        {

        }

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioAutores(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Autor autor)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioAutores(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(autor);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Autor> GetAutores()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioAutores(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetAutores();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public Autor GetAutorPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Autor autor)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioAutores(_conexionBd.AbrirConexion());
                _repositorio.Guardar(autor);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
