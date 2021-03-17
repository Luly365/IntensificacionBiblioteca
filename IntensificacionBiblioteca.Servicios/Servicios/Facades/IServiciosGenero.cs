using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServiciosGenero
    {
        List<Genero> GetGeneros();
        Genero GetGeneroPorId(int id);
        void Guardar(Genero genero);
        void Borrar(int id);
        bool Existe(Genero genero);
    }
}
