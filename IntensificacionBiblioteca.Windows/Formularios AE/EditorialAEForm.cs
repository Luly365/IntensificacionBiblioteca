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
    public partial class EditorialAEForm : MetroFramework.Forms.MetroForm
    {
        public EditorialAEForm()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboEditoriales();
            if (editorial != null)
            {
                EditorialMetroTextBox.Text = editorial.NombreEditorial;
                PaisMetroComboBox.SelectedValue = editorial.Pais.PaisId;
            }
        }

        private void CargarDatosComboEditoriales()
        {
            IServiciosPais _servicioPais = new ServiciosPaises();
            var lista = _servicioPais.GetPaises();
            var defaultPais = new Pais
            {
                PaisId = 0,
                NombrePais = "Seleccione País"
            };
            lista.Insert(0, defaultPais);
            PaisMetroComboBox.DataSource = lista;
            PaisMetroComboBox.ValueMember = "PaisId";
            PaisMetroComboBox.DisplayMember = "NombrePais";
            PaisMetroComboBox.SelectedIndex = 0;

        }

        private Editorial editorial;
        internal Editorial GetEditorial()
        {
            return editorial;
        }

        public void SetEditorial(Editorial editorial)
        {
            this.editorial = editorial;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidadDatos())
            {
                if (editorial == null)
                {
                    editorial = new Editorial();
                }

                editorial.NombreEditorial = EditorialMetroTextBox.Text;
                editorial.Pais = (Pais)PaisMetroComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidadDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(EditorialMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(EditorialMetroTextBox, "La Editorial es requerida");
            }

            if (PaisMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisMetroComboBox, "Debe seleccionar un País");
            }

            return valido;
        }
    }
}
