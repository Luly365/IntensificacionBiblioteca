using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Datos.Repositorios.Facades
{
    public interface IRepositorioLocalidades
    {
        List<LocalidadListDto> GetLista();
        void Guardar(Localidad localidad);
        bool Existe(Localidad localidad);

        void Borrar(int id);
        Localidad GetLocalidadPorId(int id);
        
    }
}
