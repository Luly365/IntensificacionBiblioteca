using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.DTOs.Estado;
using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.DTOs.Libro;
using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
using IntensificacionBiblioteca.Entidades.DTOs.Pais;
using IntensificacionBiblioteca.Entidades.DTOs.Provincia;
using IntensificacionBiblioteca.Entidades.DTOs.Socio;
using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
using IntensificacionBiblioteca.Entidades.Entidades;

using IntensificacionBiblioteca.Servicios.Servicios;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntensificacionBiblioteca.Windows.Helpers
{
    public class Helper
    {
        public static void CargarDatosComboProvincias(ref MetroComboBox combo)
        {
            //cargo las provincias en el ComboBox
            IServiciosProvincia servicioProvincia = new ServiciosProvincias();
            var lista = servicioProvincia.GetProvincias();
            var defaultProvincia = new Provincia
            {
                ProvinciaId = 0,
                NombreProvincia = "Seleccione Provincia"
            };
            lista.Insert(0, defaultProvincia);
            combo.DataSource = lista;
            combo.ValueMember = "ProvinciaId";
            combo.DisplayMember = "NombreProvincia";
            combo.SelectedIndex = 0;
        }

        internal static void CargarComboDeLibros(ref MetroComboBox libroIdMetroComboBox)
        {
            IServicioLibros servicio = new ServicioLibros();
            var lista = servicio.GetLista();
            var defaultLibros = new LibroListDto()
            {
                LibroId=0,
                Titulo="Seleccione un Libro"
            };
            lista.Insert(0, defaultLibros);
            libroIdMetroComboBox.DataSource = lista;
            libroIdMetroComboBox.ValueMember = "LibroId";
            libroIdMetroComboBox.DisplayMember = "Titulo";
            libroIdMetroComboBox.SelectedIndex = 0;


        }

        internal static void CargarComboSocios(ref MetroComboBox socioIdMetroComboBox)
        {
            IServicioSocios servicio = new ServicioSocios();
            var lista = servicio.GetLista();//nul,nul
            var defaultSocio = new SocioListDto()
            {
                SocioId=0,
                NroDoc="Seleccione Nº Doc Socio"
            };
            lista.Insert(0, defaultSocio);
            socioIdMetroComboBox.DataSource = lista;
            socioIdMetroComboBox.ValueMember = "SocioId";
            socioIdMetroComboBox.DisplayMember = "NroDoc";
            socioIdMetroComboBox.SelectedIndex = 0;
        }

        internal static void CargarComboEstadoLibro(ref MetroComboBox estadoLibroMetroComboBox)
        {
            IServiciosEstado serviciosEstado = new ServiciosEstado();
            var lista = serviciosEstado.GetEstados();
            var defaultEstado = new EstadoListDto
            {
                EstadoId = 0,
                Descripcion = "Seleccione un estado"
            };
            lista.Insert(0, defaultEstado);
            estadoLibroMetroComboBox.DataSource = lista;
            estadoLibroMetroComboBox.ValueMember = "EstadoId";
            estadoLibroMetroComboBox.DisplayMember = "Descripcion";
            estadoLibroMetroComboBox.SelectedIndex = 0;
        }



        internal static void CargarComboEditoriales(ref MetroComboBox editorialMetroComboBox, PaisListDto paisDto)
        {
            IServicioEditoriales serviciosEditorial = new ServicioEditoriales();
            var lista = serviciosEditorial.GetLista(paisDto);
            var defaultEditorial = new EditorialListDto
            {
                EditorialId = 0,
                NombreEditorial = "Seleccione una Editorial"
            };
            lista.Insert(0, defaultEditorial);
            editorialMetroComboBox.DataSource = lista;
            editorialMetroComboBox.ValueMember = "EditorialId";
            editorialMetroComboBox.DisplayMember = "NombreEditorial";
            editorialMetroComboBox.SelectedIndex = 0;
        }

        internal static void CargarComboSubGenero(ref MetroComboBox comboSubGenero, GeneroListDto generoListDto)
        {
            IServiciosSubGeneros servicioSubGenero = new ServicioSubGeneros();
            var lista = servicioSubGenero.GetLista(generoListDto);
            var defaultSubGenero = new SubGeneroListDto
            {
                SubGeneroId = 0,
                NombreSubGenero = "Seleccione un SubGenero",
            };
            lista.Insert(0, defaultSubGenero);
            comboSubGenero.DataSource = lista;
            comboSubGenero.ValueMember = "SubGeneroId";
            comboSubGenero.DisplayMember = "NombreSubGenero";
            comboSubGenero.SelectedIndex = 0;
        }

        internal static void CargarComboDeGenero(ref MetroComboBox generoMetroComboBox)
        {
            IServiciosGenero servicioGenero = new ServiciosGenero();
            var lista = servicioGenero.GetGeneros();
            var defaultGenero = new GeneroListDto
            {
                GeneroId=0,
                Descripcion="Seleccione Genero",
            };
            lista.Insert (0, defaultGenero);
            generoMetroComboBox.DataSource = lista;
            generoMetroComboBox.ValueMember = "GeneroId";
            generoMetroComboBox.DisplayMember = "Descripcion";
            generoMetroComboBox.SelectedIndex = 0;
        }

        public  static void CargarDatosComboPais(ref MetroComboBox paisMetroComboBox)
        {
            //cargo los paises en el ComboBox
            IServiciosPais servicioPais = new ServiciosPaises();
            var lista = servicioPais.GetPaises();
            var defaultPais = new PaisListDto
            {
                PaisId = 0,
                NombrePais = "Seleccione Pais"
            };
            lista.Insert(0, defaultPais);
            paisMetroComboBox.DataSource = lista;
            paisMetroComboBox.ValueMember = "PaisId";
            paisMetroComboBox.DisplayMember = "NombrePais";
            paisMetroComboBox.SelectedIndex = 0;
        }

        public static List<DetallePrestamoListDto> ConstruirListaItemsListDto(List<DetallePrestamoEditDto> itemsEditDto)
        {
            var listaDto = new List<DetallePrestamoListDto>();
            foreach (var item in itemsEditDto)
            {
                var itemDto = new DetallePrestamoListDto()
                {
                    DetallePrestamoId = item.DetallePrestamoId,
                    Titulo = item.Libro.Titulo,
                    ISBN= item.Libro.ISBN,
                    Observaciones=item.Libro.Observaciones,
                    Cantidad = item.Cantidad
                };
                listaDto.Add(itemDto);
            }

            return listaDto;
        }











        //internal static void CargarComboLocalidades(ref MetroComboBox combo, Provincia provincia)
        //{
        //    IServicioLocalidades servicioLocalidad = new ServicioLocalidades();
        //    var lista = servicioLocalidad.GetLista(provincia);
        //    var defaultLocalidad = new LocalidadListDto
        //    {
        //        LocalidadId = 0,
        //        NombreLocalidad = "Seleccione Localidad"
        //    };
        //    lista.Insert(0, defaultLocalidad);
        //    combo.DataSource = lista;
        //    combo.ValueMember = "LocalidadId";
        //    combo.DisplayMember = "NombreLocalidad";
        //    combo.SelectedIndex = 0;

        //}
    }
}
