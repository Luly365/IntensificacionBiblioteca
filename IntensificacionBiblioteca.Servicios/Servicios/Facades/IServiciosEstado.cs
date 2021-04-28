using IntensificacionBiblioteca.Entidades.DTOs.Estado;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServiciosEstado
    {
        List<EstadoListDto> GetEstados();
        EstadoEditDto GetEstadoPorId(int id);
        void Guardar(EstadoEditDto estado);
        void Borrar(int id);
        bool Existe(EstadoEditDto estado);
    }
}
