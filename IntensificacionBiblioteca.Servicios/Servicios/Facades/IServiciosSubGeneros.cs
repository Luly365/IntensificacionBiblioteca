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
        List<SubGeneroListDto> GetLista();
        void Guardar(SubGenero subGenero);
        bool Existe(SubGenero subGenero);

        void Borrar(int id);
        SubGenero GetSubGeneroPorId(int id);

    }
}
