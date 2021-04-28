using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Estado
{
    public class EstadoListDto:ICloneable
    {
        public int EstadoId { get; set; }
        public string Descripcion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();//copia superficial del objeto
        }

    }
}
