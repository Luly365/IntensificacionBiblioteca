using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Servicios.Servicios.Facades
{
    public interface IServicioLocalidades
    {
        List<LocalidadListDto> GetLista(Provincia provincia);
        void Guardar(LocalidadEditDto localidadEditDto);
        bool Existe(LocalidadEditDto localidad);
        void Borrar(int localidadId);
        LocalidadEditDto GetLocalidadPorId(int id);
    }
}
