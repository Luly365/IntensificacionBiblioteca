using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Libro
{
    public class LibroListDto:ICloneable
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Editorial { get; set; }
        public string NombreGenero { get; set; }
        public string NombreSubGenero { get; set; }
        public DateTime FechaIncorporacion { get; set; }
        public string DescripcionEstado { get; set; }
        public string Observaciones { get; set; }
        public bool Disponible { get; set; }

        public int Stock { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
