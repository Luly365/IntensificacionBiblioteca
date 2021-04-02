using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class SubGenero
    {
        public int SubGeneroId { get; set; }
        public string NombreSubGenero { get; set; }
        public Genero genero { get; set; }
    }
}
