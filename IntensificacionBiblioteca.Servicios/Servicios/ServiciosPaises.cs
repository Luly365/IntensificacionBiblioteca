using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Pais;
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
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioPaises(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(PaisEditDto paisDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioPaises(_conexionBd.AbrirConexion());
                var pais = new Pais
                {
                    PaisId = paisDto.PaisId,
                    NombrePais = paisDto.NombrePais
                };
                var existe = _repositorio.Existe(pais);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<PaisListDto> GetPaises()
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

        public PaisEditDto GetPaisPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioPaises(_conexionBd.AbrirConexion());
                var pais = _repositorio.GetPaisPorId(id);
                _conexionBd.CerrarConexion();
                return pais;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(PaisEditDto paisDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioPaises(_conexionBd.AbrirConexion());
                var pais = new Pais
                {
                    PaisId = paisDto.PaisId,
                    NombrePais = paisDto.NombrePais
                };
                _repositorio.Guardar(pais);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
