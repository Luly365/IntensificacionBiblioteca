using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class AutorLibro
    {
        public int AutorLibroId { get; set; }
        public Libro Titulo { get; set; }
        public Autor NombreAutor { get; set; }
    }
}
