using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo
{
    public class DetallePrestamoListDto
    {
        public int DetallePrestamoId { get; set; }
        public string  Titulo { get; set; }
        public string  ISBN { get; set; }
        public string Observaciones { get; set; }
        public int Cantidad { get; set; }

       
    }
}
