using IntensificacionBiblioteca.Entidades.DTOs.Libro;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioLibros
    {
        List<LibroListDto> GetLista();
        bool Existe(Libro libro);
        void Guardar(Libro libro);
        LibroEditDto GetLibroPorId(int libroId);
        void Borrar(int libroId);
    }
}
