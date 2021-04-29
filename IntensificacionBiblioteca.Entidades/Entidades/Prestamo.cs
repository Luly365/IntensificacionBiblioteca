using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public Socio Socio { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public List<DetallePrestamo> detallePrestamo { get; set; } = new List<DetallePrestamo>();
    }
}
