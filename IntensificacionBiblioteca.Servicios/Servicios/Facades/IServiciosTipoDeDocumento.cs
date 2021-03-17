using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServiciosTipoDeDocumento
    {
        List<TipoDeDocumento> GetTipoDeDocumentos();
        TipoDeDocumento GetTipoDeDocPorId(int id);
        void Guardar(TipoDeDocumento tipoDeDocumento);
        void Borrar(int id);
        bool Existe(TipoDeDocumento tipoDeDocumento);
    }
}
