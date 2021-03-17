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
    public class ServiciosPaises : IServiciosPais
    {
        //servicio le pide informacion al repositorio a traves de una conexion 
        private IRepositorioPaises _repositorio;
        private ConexionBd _conexionBd;
        public ServiciosPaises()
        {
            
        }

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Pais pais)
        {
            throw new NotImplementedException();
        }

        public List<Pais> GetPaises()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioPaises(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetPaises();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            { 
                throw new Exception(e.Message);
            }
            
        }

        public Pais GetPaisPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Pais pais)
        {
            throw new NotImplementedException();
        }
    }
}
