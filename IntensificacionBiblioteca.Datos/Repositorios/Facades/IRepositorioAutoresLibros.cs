using IntensificacionBiblioteca.Entidades.DTOs.AutorLibro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioAutoresLibros
    {
        List<AutorLibroListDto> GetLista();
    }
}
