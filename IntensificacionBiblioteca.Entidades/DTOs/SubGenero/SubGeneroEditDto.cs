using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.SubGenero
{
    public class SubGeneroEditDto
    {
        public int SubGeneroId { get; set; }
        public string NombreSubGenero { get; set; }
        public GeneroListDto Genero{ get; set; }//en el codigo aparece distinto que en el video 
    }
}
