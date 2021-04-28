using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
using IntensificacionBiblioteca.Entidades.DTOs.Provincia;
using IntensificacionBiblioteca.Entidades.DTOs.TipoDeDoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntensificacionBiblioteca.Entidades.DTOs.Socio
{
    public class SocioEditDto
    {
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDeDocListDto TipoDeDocumento { get; set; }//tabla 
        public string NroDoc { get; set; }
        public string Direccion { get; set; }
        public LocalidadListDto Localidad { get; set; }//tabla 
        //public ProvinciaListDto ProvinciaListDto { get; set; }//tabla. no necesito esta tabla porque no la debo mostrar en mi tabla de AESocios
        public DateTime FechaNac { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
