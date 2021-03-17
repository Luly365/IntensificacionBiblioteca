using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServiciosPais
    {
        List<Pais> GetPaises();
        Pais GetPaisPorId(int id);
        void Guardar(Pais pais);
        void Borrar(int id);
        bool Existe(Pais pais);
    }
}
