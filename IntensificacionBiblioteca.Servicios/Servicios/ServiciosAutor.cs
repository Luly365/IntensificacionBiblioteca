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
            throw new NotImplementedException();
        }

        public bool Existe(Autor autor)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
