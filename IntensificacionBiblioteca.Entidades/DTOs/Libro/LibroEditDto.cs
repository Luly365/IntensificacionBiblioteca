using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.DTOs.Estado;
using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
using IntensificacionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Libro
{
    public class LibroEditDto
    {
        public int LibroId { get; set; }//0
        public string Titulo { get; set;}//1
        public string ISBN { get; set; }//2
        public EditorialListDto Editorial { get; set; }//3
        public GeneroListDto Genero { get; set; }//4
        public SubGeneroListDto SubGenero { get; set; }//5
        public DateTime FechaIncorporacion { get; set; }//6
        public EstadoListDto Estado { get; set; }//7
        public string Observaciones { get; set; }//8
        public bool Disponible { get; set; }//9
        public int Stock { get; set; }//10
    }
}
