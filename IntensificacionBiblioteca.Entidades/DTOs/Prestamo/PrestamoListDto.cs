using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Prestamo
{
    public class PrestamoListDto
    {
        public int PrestamoId { get; set; }
        public string NombreSocio { get; set; }
        public string  ApellidoSocio { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public List<DetallePrestamoListDto> ItemsPrestamo { get; set; } = new List<DetallePrestamoListDto>();
        //public int TotalLibrosPrestado => ItemsPrestamo.Sum( la Cantidad);
    }
}
