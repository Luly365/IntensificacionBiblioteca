using IntensificacionBiblioteca.Entidades.DTOs.AutorLibro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServicioAutoresLibros
    {
        List<AutorLibroListDto> GetLista();
    }
}
