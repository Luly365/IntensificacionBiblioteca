using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioPaises
    {//estipulo los metodos pero no los desarrollo
        List<Pais> GetPaises();
        Pais GetPaisPorId(int id);
        void Guardar(Pais pais);
        void Borrar(int id);
        bool Existe(Pais pais);
        
    }
}
