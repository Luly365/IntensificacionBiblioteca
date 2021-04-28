using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Editorial
{
    public class EditorialListDto:ICloneable
    {
        public int EditorialId { get; set; }
        public string NombreEditorial { get; set; }
        public string  NombrePais { get; set; }//cambie aca por string paisListDto
    

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
