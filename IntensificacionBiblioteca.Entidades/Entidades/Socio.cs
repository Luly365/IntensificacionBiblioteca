using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.Entidades
{
    public class Socio
    {
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public int TipoDeDocumentoId { get; set; }
        public string NroDoc { get; set; }
        public string Direccion { get; set; }
        public Localidad Localidad { get; set; }
        public Provincia Provincia { get; set; }
        public DateTime FechaNac { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Sancionado { get; set; }
        public bool Activo { get; set; }
    }
}
