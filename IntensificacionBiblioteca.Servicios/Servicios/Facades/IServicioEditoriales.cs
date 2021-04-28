using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.DTOs.Pais;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServicioEditoriales
    {
        List<EditorialListDto> GetLista(PaisListDto paisDto);
        void Guardar(EditorialEditDto editorialEditDto);
        bool Existe(EditorialEditDto editorial);
        void Borrar(int editorialId);
        EditorialEditDto GetEditorialPorId(int id);


        
    }
}
