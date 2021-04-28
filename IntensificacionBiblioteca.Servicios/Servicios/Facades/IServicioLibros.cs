using IntensificacionBiblioteca.Entidades.DTOs.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServicioLibros
    {
        List<LibroListDto> GetLista();//puede sobrecargarse
        bool Existe(LibroEditDto libroEditDto);
        void Guardar(LibroEditDto libroEditDto);
        void Borrar(int libroId);
        LibroEditDto GetLibroPorId(int libroId);
    }
}
