using IntensificacionBiblioteca.Entidades.DTOs.Pais;
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
        List<PaisListDto> GetPaises();
        PaisEditDto GetPaisPorId(int id);
        void Guardar(PaisEditDto pais);
        void Borrar(int id);
        bool Existe(PaisEditDto pais);
    }
}
