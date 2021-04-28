using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServiciosGenero
    {
        List<GeneroListDto> GetGeneros();
        GeneroEditDto GetGeneroPorId(int id);
        void Guardar(GeneroEditDto genero);
        void Borrar(int id);
        bool Existe(GeneroEditDto genero);
    }
}
