using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioEditoriales
    {
        List<EditorialListDto> GetLista();
        void Guardar(Editorial editorial);
        bool Existe(Editorial editorial);

        void Borrar(int id);
        Editorial GetEditorialPorId(int id);
    }
}
