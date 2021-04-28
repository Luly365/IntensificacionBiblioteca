using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Socio
{
    public class SocioListDto
    {
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDoc { get; set; }
        public string Direccion { get; set; }
        public string NombreLocalidad { get; set; }//tipo localidad nombrelocalidad
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Sancionado { get; set; }
        public bool Activo { get; set; }
    }
}
