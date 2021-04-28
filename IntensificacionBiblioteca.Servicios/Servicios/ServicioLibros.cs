using IntensificacionBiblioteca.Datos;
using IntensificacionBiblioteca.Datos.Repositorios;
using IntensificacionBiblioteca.Datos.Repositorios.Facades;
using IntensificacionBiblioteca.Entidades.DTOs.Libro;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios
{
    public class ServicioLibros : IServicioLibros
    {
        private ConexionBd _conexionBd;
        private IRepositorioLibros _repositorio;
        private IRepositorioEditoriales _repositorioEditoriales;
        private IRepositorioPaises _repositorioPaises;
        private IRepositorioGeneros _repositorioGenero;
        private IRepositorioSubGenero _repositorioSubGenero;
        private IRepositorioEstados _repositorioEstados;

        public ServicioLibros()
        {

        }

        public void Borrar(int libroId)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLibros(_conexionBd.AbrirConexion());
                _repositorio.Borrar(libroId);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(LibroEditDto libroEditDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLibros(_conexionBd.AbrirConexion());
                Libro libro = new Libro
                {
                    LibroId = libroEditDto.LibroId,
                    Titulo = libroEditDto.Titulo,
                    ISBN = libroEditDto.ISBN,

                    Editorial = new Editorial()
                    {
                        EditorialId = libroEditDto.Editorial.EditorialId,
                        NombreEditorial = libroEditDto.Editorial.NombreEditorial,
                        Pais = new Pais()
                        {
                            //PaisId=libroEditDto.Editorial.Pais.PaisId,
                            //NombrePais = libroEditDto.Editorial.Pais.NombrePais

                            PaisId = libroEditDto.Editorial.EditorialId,//aca no le tendria que pasar un paisId??, pero me da error
                            NombrePais = libroEditDto.Editorial.NombrePais

                        }
                    },
                    Genero = new Genero()
                    {
                        GeneroId = libroEditDto.Genero.GeneroId,
                        Descripcion = libroEditDto.Genero.Descripcion
                    },

                    SubGenero = new SubGenero()
                    {
                        SubGeneroId = libroEditDto.SubGenero.SubGeneroId,
                        NombreSubGenero = libroEditDto.SubGenero.NombreSubGenero,
                        genero = new Genero()
                        {
                            GeneroId = libroEditDto.Genero.GeneroId,
                            Descripcion = libroEditDto.Genero.Descripcion
                        }
                    },
                    FechaIncorporacion = libroEditDto.FechaIncorporacion,
                    Estado = new Estado()
                    {
                        EstadoId = libroEditDto.Estado.EstadoId,
                        Descripcion = libroEditDto.Estado.Descripcion
                    },
                    Observaciones = libroEditDto.Observaciones,
                    Disponible = libroEditDto.Disponible
                };

                var existe = _repositorio.Existe(libro);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar ver si existe la ciudad");
            }
        }

        public LibroEditDto GetLibroPorId(int libroId)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioPaises = new RepositorioPaises(_conexionBd.AbrirConexion());
                _repositorioEditoriales = new RepositorioEditoriales(_conexionBd.AbrirConexion(), _repositorioPaises);//le deno pasar el repositorio de pais???
                _repositorioGenero = new RepositorioGeneros(_conexionBd.AbrirConexion());
                _repositorioSubGenero = new RepositorioSubGeneros(_conexionBd.AbrirConexion(),_repositorioGenero );
                _repositorioEstados = new RepositorioEstados(_conexionBd.AbrirConexion());
                _repositorio = new RepositorioLibros(_conexionBd.AbrirConexion(), _repositorioPaises, _repositorioEditoriales, _repositorioGenero,_repositorioSubGenero, _repositorioEstados);//VA EN ORDEN 
                var libro = _repositorio.GetLibroPorId(libroId);
                _conexionBd.CerrarConexion();
                return libro;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<LibroListDto> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLibros(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexionBd.CerrarConexion();
                return lista;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(LibroEditDto libroEditDto)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLibros(_conexionBd.AbrirConexion());
                Libro libro = new Libro
                {
                    LibroId = libroEditDto.LibroId,
                    Titulo = libroEditDto.Titulo,
                    ISBN = libroEditDto.ISBN,

                    Editorial = new Editorial()
                    {
                        EditorialId = libroEditDto.Editorial.EditorialId,
                        NombreEditorial = libroEditDto.Editorial.NombreEditorial,
                        Pais = new Pais()
                        {
                            //PaisId = libroEditDto.Editorial.Pais.PaisId,
                            //NombrePais = libroEditDto.Editorial.Pais.NombrePais
                            PaisId = libroEditDto.Editorial.EditorialId,//aca no le tendria que pasar un paisId??, pero me da error
                            NombrePais = libroEditDto.Editorial.NombrePais

                        }
                    },
                    Genero = new Genero()
                    {
                        GeneroId = libroEditDto.Genero.GeneroId,
                        Descripcion = libroEditDto.Genero.Descripcion
                    },

                    SubGenero = new SubGenero()
                    {
                        SubGeneroId = libroEditDto.SubGenero.SubGeneroId,
                        NombreSubGenero = libroEditDto.SubGenero.NombreSubGenero,
                        genero = new Genero()
                        {
                            GeneroId = libroEditDto.Genero.GeneroId,
                            Descripcion = libroEditDto.Genero.Descripcion
                        }
                    },
                    FechaIncorporacion = libroEditDto.FechaIncorporacion,
                    Estado = new Estado()
                    {
                        EstadoId = libroEditDto.Estado.EstadoId,
                        Descripcion = libroEditDto.Estado.Descripcion
                    },
                    Observaciones = libroEditDto.Observaciones,
                    Disponible = libroEditDto.Disponible
                };

                _repositorio.Guardar(libro);

                libroEditDto.LibroId = libro.LibroId;
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}

