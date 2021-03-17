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
    public class ServiciosEstado : IServiciosEstado
    {

        private IRepositorioEstados _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosEstado()
        {

        }

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Estado estado)
        {
            throw new NotImplementedException();
        }

        public Estado GetEstadoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estado> GetEstados()
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

        public void Guardar(Estado estado)
        {
            throw new NotImplementedException();
        }
    }
}
