using IntensificacionBiblioteca.Entidades.DTOs.Genero;
using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
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
    public partial class SubGeneroAEForm : MetroFramework.Forms.MetroForm
    {
        public SubGeneroAEForm()
        {
            InitializeComponent();
        }

        private SubGeneroEditDto subGenero;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboGeneros();
            if (subGenero != null)
            {
                SubGeneroMetroTextBox.Text = subGenero.NombreSubGenero;
                GenerosMetroComboBox.SelectedValue = subGenero.Genero.GeneroId;
            }

        }

        private void CargarDatosComboGeneros()
        {
            IServiciosGenero _serviciosGenero = new ServiciosGenero();
            var lista = _serviciosGenero.GetGeneros();
            var defaultGenero = new GeneroListDto
            {
                GeneroId = 0,
                Descripcion = "Seleccione Genero" 
            };
            lista.Insert(0, defaultGenero);
            GenerosMetroComboBox.DataSource = lista;
            GenerosMetroComboBox.ValueMember = "GeneroId";
            GenerosMetroComboBox.DisplayMember = "Descripcion";//nombre genero?
            GenerosMetroComboBox.SelectedIndex = 0;
        }

        private void SubGeneroAEForm_Load(object sender, EventArgs e)
        {
            
        }

        internal SubGeneroEditDto GetSubGenero()
        {
            return subGenero;
        }

        public void SetSubGenero(SubGeneroEditDto subGenero)
        {
            this.subGenero = subGenero;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidadDatos())
            {
                if (subGenero == null)
                {
                    subGenero = new SubGeneroEditDto();
                }

                subGenero.NombreSubGenero = SubGeneroMetroTextBox.Text;
                subGenero.Genero = (GeneroListDto)GenerosMetroComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidadDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(SubGeneroMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(SubGeneroMetroTextBox, "El SubGenero es requerido");
            }

            if (GenerosMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(GenerosMetroComboBox, "Debe seleccionar un Genero");
            }

            return valido;
        }
    }
}
