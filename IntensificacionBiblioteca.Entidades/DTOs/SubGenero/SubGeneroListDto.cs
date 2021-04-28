using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.SubGenero
{
    public class SubGeneroListDto: ICloneable
    {
        public int SubGeneroId { get; set; }
        public string NombreSubGenero { get; set; } 
        public string NombreGenero { get; set; }//el nombre genero tambien es ""descripcion"" 

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
