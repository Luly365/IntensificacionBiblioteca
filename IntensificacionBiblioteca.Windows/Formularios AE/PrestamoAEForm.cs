using IntensificacionBiblioteca.Entidades.DTOs;
using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Libro;
using IntensificacionBiblioteca.Entidades.DTOs.Prestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Provincia;
using IntensificacionBiblioteca.Entidades.DTOs.Socio;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    public partial class PrestamoAEForm : MetroFramework.Forms.MetroForm
    {
        public PrestamoAEForm()
        {
            InitializeComponent();
        }

        private PrestamoEditDto prestamoDto;

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal PrestamoEditDto GetPrestamo()
        {
            return prestamoDto;
        }

        private void PrestamoAEForm_Load(object sender, EventArgs e)
        {
            Helper.CargarComboSocios(ref SocioIdMetroComboBox);
            Helper.CargarComboDeLibros(ref LibroIdMetroComboBox);
            carrito = new CarritoDto();
        }

        private void SocioIdMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SocioIdMetroComboBox.SelectedIndex > 0)
            {
                socioListDto = (SocioListDto)SocioIdMetroComboBox.SelectedItem;
                MostrarDatosSocios(socioListDto);
            }
        }

        private void MostrarDatosSocios(SocioListDto listDto)
        {
            NombreMetroTextBox.Text = listDto.Nombre;
            ApellidoMetroTextBox.Text = listDto.Apellido;
            CalleMetroTextBox.Text = listDto.Direccion;
            TelCelMetroTextBox.Text = listDto.TelefonoMovil;
            EMailMetroTextBox.Text = listDto.CorreoElectronico;
        }

        private CarritoDto carrito;
        private DetallePrestamoEditDto detallePrestamo;
        private SocioListDto socioListDto;
        private LibroListDto libroDto;
       


        private void AceptarMetroButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatosLibros())
            {
                if (detallePrestamo == null)
                {
                    detallePrestamo = new DetallePrestamoEditDto();
                }

                detallePrestamo.Libro = libroDto;
                carrito.AgregarAlCarrito(detallePrestamo);
                MostrarDatosSociosEnGrilla();
            }
        }

        private void MostrarDatosSociosEnGrilla()
        {
            CargarLibrosPrestadosMetroGrid.Rows.Clear();
            foreach (var item in carrito.GetItems())
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, item);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            CargarLibrosPrestadosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, DetallePrestamoEditDto items)
        {

            r.Cells[cmnTitulo.Index].Value = items.Libro.Titulo;
            r.Cells[cmnISBN.Index].Value = items.Libro.ISBN;
            r.Tag = items;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(CargarLibrosPrestadosMetroGrid);
            return r;
        }

        private bool ValidarDatosLibros()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (LibroIdMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(LibroIdMetroComboBox, "Debe seleccionar un libro");
            }
            
            if (SocioIdMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(SocioIdMetroComboBox, "Debe seleccionar un Socio");
            }

            // validar la cantidad de libros permitidas cuando le agregue el control 

            return valido;
        }

        private void LibroIdMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LibroIdMetroComboBox.SelectedIndex > 0)
            {
                libroDto = (LibroListDto)LibroIdMetroComboBox.SelectedItem;
            }
        }

        private void cancalarMetroButton_Click(object sender, EventArgs e)
        {
            InicializarControlesPrestamo();
        }

        private void InicializarControlesPrestamo()
        {
            LibroIdMetroComboBox.SelectedIndex = 0;
        }



        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (SocioIdMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(SocioIdMetroComboBox, "Debe seleccionar un Socio");
                
            }
            if (LibroIdMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(LibroIdMetroComboBox, "Debe seleccionar un libro");
            }

            return valido;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                prestamoDto = new PrestamoEditDto();
                prestamoDto.NombreSocio = socioListDto;
                prestamoDto.FechaPrestamo = FechaPrestamoMetroDateTime.Value;
                foreach (var item in carrito.GetItems())
                {
                    var itemEditDto = new DetallePrestamoEditDto()
                    {
                        Libro = item.Libro
                        //agregar otros atributos
                    };
                    prestamoDto.DetallePrestamo.Add(itemEditDto);
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
