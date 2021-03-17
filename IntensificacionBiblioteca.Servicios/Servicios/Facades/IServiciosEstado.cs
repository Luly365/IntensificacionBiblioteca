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
        List<Estado> GetEstados();
        Estado GetEstadoPorId(int id);
        void Guardar(Estado estado);
        void Borrar(int id);
        bool Existe(Estado estado);
    }
}
