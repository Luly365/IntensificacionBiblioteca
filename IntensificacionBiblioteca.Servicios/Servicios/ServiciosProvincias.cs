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
            throw new NotImplementedException();
        }

        public bool Existe(Provincia provincia)
        {
            throw new NotImplementedException();
        }

        public Provincia GetProvinciaPorId(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
