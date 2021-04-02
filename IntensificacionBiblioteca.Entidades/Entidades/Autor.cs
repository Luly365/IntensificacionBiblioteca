using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class Autor: ICloneable
    {
        public int AutorId { get; set; }
        public string NombreAutor { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();//copia superficial del objeto
        }
    }
}
