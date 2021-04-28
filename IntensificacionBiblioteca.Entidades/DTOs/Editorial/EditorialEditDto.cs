using IntensificacionBiblioteca.Entidades.DTOs.Pais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Editorial
{
    public class EditorialEditDto
    {
        public int EditorialId { get; set; }
        public string NombreEditorial { get; set; }
        public PaisListDto Pais { get; set; }
    }
}
