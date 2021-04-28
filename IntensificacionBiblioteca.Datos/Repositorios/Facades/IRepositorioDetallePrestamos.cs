using IntensificacionBiblioteca.Entidades;
using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioDetallePrestamos
    {
        List<DetallePrestamoListDto> GetLista(int prestamoId);
        void Guardar(DetallePrestamo detalle);
    }
}
