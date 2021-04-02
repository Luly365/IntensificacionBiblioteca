using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServicioEditoriales : IServicioEditoriales
    {
        private ConexionBd _conexionBd;
        private IRepositorioEditoriales _repositorio;
        private IRepositorioPaises _repositorioPaises;

        

        public ServicioEditoriales()
        {

        }

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Editorial editorial)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(editorial);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar ver si existe la ciudad");
            }
        }

        public Editorial GetEditorialPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioPaises = new RepositorioPaises(_conexionBd.AbrirConexion());
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion(), _repositorioPaises);
                var ciudad = _repositorio.GetEditorialPorId(id);
                _conexionBd.CerrarConexion();
                return ciudad;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<EditorialListDto> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Editorial editorial)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion());
                _repositorio.Guardar(editorial);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}


         