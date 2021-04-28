using IntensificacionBiblioteca.Entidades.DTOs.Estado;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioEstados
    {
        List<EstadoListDto> GetEstados();
        EstadoEditDto GetEstadoPorId(int id);//
        void Guardar(Estado estado);
        void Borrar(int id);
        bool Existe(Estado estado);

    }
}
