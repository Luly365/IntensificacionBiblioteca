using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Localidad
{
    public class LocalidadListDto:ICloneable
    {
        public int LocalidadId { get; set; }// a este campo lo tengo que sacar?
        public string NombreLocalidad { get; set; }
        public string NombreProvincia { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
