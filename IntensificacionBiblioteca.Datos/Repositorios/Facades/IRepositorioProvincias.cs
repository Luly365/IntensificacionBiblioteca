using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioProvincias
    {
        List<Provincia> GetProvincias();
        Provincia GetProvinciaPorId(int id);
        void Guardar(Provincia provincia);
        void Borrar(int id);
        bool Existe(Provincia provincia);

    }
}
