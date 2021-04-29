using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.DTOs.Estado;
using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.DTOs.Libro;
using IntensificacionBiblioteca.Entidades.DTOs.Pais;
using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
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
    public partial class LibroAEForm : MetroFramework.Forms.MetroForm
    {
        public LibroAEForm()
        {
            InitializeComponent();
        }

        private LibroEditDto libroEditDto;
        private PaisListDto paisDto;// lo agregue no se si esta bien 

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarComboDeGenero(ref GeneroMetroComboBox);
            Helper.CargarComboEstadoLibro(ref EstadoLibroMetroComboBox);
            Helper.CargarComboEditoriales(ref EditorialMetroComboBox, paisDto);
            

            if (libroEditDto!=null)
            {
                //muestra titulo
                TituloMetroTextBox.Text = libroEditDto.Titulo;
                //isbn
                ISBNMetroTextBox.Text = libroEditDto.ISBN;
                //editorial se carga
                EditorialMetroComboBox.SelectedValue = libroEditDto.Editorial.EditorialId;
                // cargar mi genero
                GeneroMetroComboBox.SelectedValue = libroEditDto.Genero.GeneroId;
                //cargo subgenero
                Helper.CargarComboSubGenero(ref SubGeneroMetroComboBox, libroEditDto.Genero);
                SubGeneroMetroComboBox.SelectedValue = libroEditDto.SubGenero.SubGeneroId;
                //estado
                EstadoLibroMetroComboBox.SelectedValue = libroEditDto.Estado.EstadoId;
                //fecha incorporacion
                FechaIncorporacionMetroDateTime.Value = libroEditDto.FechaIncorporacion;
                // observaciones
                ObservacionestextBox.Text = libroEditDto.Observaciones;
                //check box
                DisponibleMetroCheckBox.Checked = libroEditDto.Disponible;
                //muestra el stock 
                StockMetroTextBox.Text = libroEditDto.Stock.ToString();
            }
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void GeneroMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GeneroMetroComboBox.SelectedIndex!= 0)
            {
                GeneroListDto generoListDto = (GeneroListDto)GeneroMetroComboBox.SelectedItem;
                Helper.CargarComboSubGenero(ref SubGeneroMetroComboBox, generoListDto);
            }
            else
            {
                SubGeneroMetroComboBox.DataSource = null;
            }

        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (libroEditDto == null)
                {
                    libroEditDto = new LibroEditDto();
                }

                libroEditDto.Titulo = TituloMetroTextBox.Text;
                libroEditDto.ISBN = ISBNMetroTextBox.Text;
                libroEditDto.Editorial = (EditorialListDto)EditorialMetroComboBox.SelectedItem;
                libroEditDto.Genero = (GeneroListDto)GeneroMetroComboBox.SelectedItem;
                libroEditDto.SubGenero = (SubGeneroListDto)SubGeneroMetroComboBox.SelectedItem;
                libroEditDto.Estado = (EstadoListDto)EstadoLibroMetroComboBox.SelectedItem;
                libroEditDto.FechaIncorporacion = FechaIncorporacionMetroDateTime.Value;
                libroEditDto.Observaciones = ObservacionestextBox.Text;
                libroEditDto.Disponible = DisponibleMetroCheckBox.Checked;
                libroEditDto.Stock = int.Parse(StockMetroTextBox.Text);


                DialogResult = DialogResult.OK;


            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TituloMetroTextBox.Text) || string.IsNullOrWhiteSpace(TituloMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(TituloMetroTextBox, "Debe Ingresar el Titulo Del Libro");
            }

            if (string.IsNullOrEmpty(ISBNMetroTextBox.Text) || string.IsNullOrWhiteSpace(ISBNMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ISBNMetroTextBox, "Debe Ingresar el ISBN Del Libro");
            }

            if (EditorialMetroComboBox.SelectedIndex==0) 
            {
                valido = false;
                errorProvider1.SetError(EditorialMetroComboBox, "Debe elegir la Editorial del Libro");
            }

            if (GeneroMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(GeneroMetroComboBox, "Debe elegir el Genero del Libro");
            }

            if (SubGeneroMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(SubGeneroMetroComboBox, "Debe elegir el SubGenero del Libro");
            }

            if (EstadoLibroMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(EstadoLibroMetroComboBox, "Debe elegir el Estado del Libro");
            }

            if (FechaIncorporacionMetroDateTime.Value.Date>DateTime.Today)
            {
                valido = false;
                errorProvider1.SetError(FechaIncorporacionMetroDateTime, "Fecha mal ingresada");
            }
            if (!double.TryParse(StockMetroTextBox.Text, out double stock))
            {
                valido = false;
                errorProvider1.SetError(StockMetroTextBox, "Stock mal ingresado");
            }
            else if (stock < 0 || stock > int.MaxValue)
            {
                valido = false;
                errorProvider1.SetError(StockMetroTextBox, "Stock fuera del rango permitido");
            }

            return valido;
        }

        internal LibroEditDto GetLibro()
        {
            return libroEditDto;
        }

        public void SetLibro(LibroEditDto libroEditDto)
        {
            this.libroEditDto = libroEditDto;
        }
    }
}
