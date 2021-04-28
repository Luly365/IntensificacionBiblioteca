using IntensificacionBiblioteca.Entidades.DTOs.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo
{
    public class DetallePrestamoEditDto
    {
        public int DetallePrestamoId { get; set; }
        public int PrestamoId { get; set; }
        public LibroListDto Libro { get; set; }
        public int Cantidad { get; set; }

        
    }
}
