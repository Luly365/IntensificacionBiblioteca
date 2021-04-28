using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServiciosSubGeneros
    {
        List<SubGeneroListDto> GetLista(GeneroListDto genero);
        void Guardar(SubGeneroEditDto subGeneroEditDto);
        bool Existe(SubGeneroEditDto subGenero);

        void Borrar(int id);
        SubGeneroEditDto GetSubGeneroPorId(int id);

    }
}
