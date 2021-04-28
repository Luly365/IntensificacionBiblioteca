using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class DetallePrestamo
    {

        public int DetallePedidoId { get; set; }
        public Prestamo Prestamo { get; set; }
        public Libro Libro { get; set; }
        public int cantidad { get; set; }


    }
}
