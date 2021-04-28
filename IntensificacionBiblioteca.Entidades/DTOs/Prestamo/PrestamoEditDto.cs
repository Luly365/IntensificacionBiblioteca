using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Socio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Prestamo
{
    public class PrestamoEditDto
    {
        public int PrestamoId { get; set; }
        public SocioListDto NombreSocio { get; set; }
        public SocioListDto ApellidoSocio { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public List<DetallePrestamoEditDto> DetallePrestamo { get; set; } = new List<DetallePrestamoEditDto>();
    }
}
