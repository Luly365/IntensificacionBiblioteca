using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioAutores
    {
        List<Autor> GetAutores();
        Autor GetAutorPorId(int id);
        void Guardar(Autor autor);
        void Borrar(int id);
        bool Existe(Autor autor);
    }
}
