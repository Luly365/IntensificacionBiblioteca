using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class Editorial
    {
        public int EditorialId { get; set; }
        public string NombreEditorial { get; set; }
        public Pais Pais { get; set; }

    }
}
