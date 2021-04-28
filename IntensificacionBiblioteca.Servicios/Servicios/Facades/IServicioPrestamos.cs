using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Prestamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServicioPrestamos
    {
        List<PrestamoListDto> GetLista();
        void Guardar(PrestamoEditDto prestamoDto);
        PrestamoEditDto GetPrestamoPorId(int id);

        List<DetallePrestamoListDto> GetDetalle(int detalleDtoPrestamoId);

    }
}
