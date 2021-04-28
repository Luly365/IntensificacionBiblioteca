using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
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

        public bool Existe(EditorialEditDto editorialDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion());
                Editorial editorial = new Editorial
                {
                    EditorialId= editorialDto.EditorialId,
                    NombreEditorial=editorialDto.NombreEditorial,
                    Pais = new Pais
                    {
                        PaisId = editorialDto.Pais.PaisId,
                        NombrePais = editorialDto.Pais.NombrePais
                    }
                };

                var existe = _repositorio.Existe(editorial);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar ver si existe la ciudad");
            }
        }

        public EditorialEditDto GetEditorialPorId(int id)
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

        public List<EditorialListDto> GetLista(PaisListDto paisDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista(paisDto);
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(EditorialEditDto editorialDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEditoriales(_conexionBd.AbrirConexion());
                Editorial editorial = new Editorial
                {
                    EditorialId=editorialDto.EditorialId,
                    NombreEditorial=editorialDto.NombreEditorial,
                    Pais = new Pais
                    {
                        PaisId = editorialDto.Pais.PaisId,
                        NombrePais = editorialDto.Pais.NombrePais
                    }

                };
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


         