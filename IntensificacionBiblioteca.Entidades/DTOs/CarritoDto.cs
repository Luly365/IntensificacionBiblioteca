using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs
{
    public class CarritoDto
    {
        public List<DetallePrestamoEditDto> ItemsPrestamo { get; set; } = new List<DetallePrestamoEditDto>();

        public CarritoDto()
        {

        }

        public void AgregarAlCarrito(DetallePrestamoEditDto item)
        {

            var itemEnCarrito = ItemsPrestamo.SingleOrDefault(iv => iv.Libro.LibroId == item.Libro.LibroId);

            if (itemEnCarrito == null)
            {

                ItemsPrestamo.Add(item);
            }
            else
            {//suma 
                itemEnCarrito.Cantidad += item.Cantidad;
            }
        }

        public List<DetallePrestamoEditDto> GetItems()
        {
            return ItemsPrestamo;
        }

      

        

    }
}
