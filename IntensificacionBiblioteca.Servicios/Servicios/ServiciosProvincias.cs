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
    public class ServiciosProvincias : IServiciosProvincia
    {
        private IRepositorioProvincias _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosProvincias()
        {
        }
        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Provincia provincia)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(provincia);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Provincia GetProvinciaPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                var provincia = _repositorio.GetProvinciaPorId(id);
                _conexionBd.CerrarConexion();
                return provincia;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Provincia> GetProvincias()
        {
            try
            {
                _conexionBd = new ConexionBd();//creo la conexion
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());//creo el repositorio
                var lista = _repositorio.GetProvincias();//obtengo los paises en una lista
                _conexionBd.CerrarConexion();//cierro la conexion 
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Provincia provincia)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                _repositorio.Guardar(provincia);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
