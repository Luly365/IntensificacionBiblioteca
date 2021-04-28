using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.AutorLibro
{
    public class AutorLibroListDto
    {
        public int AutorLibroId { get; set; }
        public string Titulo { get; set; }
        public string NombreAutor { get; set; }
    }
}
