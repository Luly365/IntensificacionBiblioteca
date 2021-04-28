using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioGeneros
    {
        List<GeneroListDto> GetGeneros();
        GeneroEditDto GetGeneroPorId(int id);
        void Guardar(Genero genero);
        void Borrar(int id);
        bool Existe(Genero genero);
    }
}
