using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public Editorial Editorial { get; set; }
        public Genero Genero { get; set; }
        public SubGenero SubGenero { get; set; }
        public DateTime FechaIncorporacion { get; set; }
        public Estado Estado { get; set; }
        public string Observaciones { get; set; }
        public bool Disponible { get; set; }
        public int Stock { get; set; }
    }
}
