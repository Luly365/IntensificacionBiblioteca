using IntensificacionBiblioteca.Entidades.DTOs.Prestamo;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioPrestamos
    {
        List<PrestamoListDto> GetLista();
        void Guardar(Prestamo prestamoDto);
        PrestamoEditDto GetPrestamoPorId(int id);
    }
}
