using IntensificacionBiblioteca.Entidades.DTOs.Socio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioSocios
    {
        List<SocioListDto> GetLista();
    }
}
