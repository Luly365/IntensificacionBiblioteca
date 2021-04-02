using IntensificacionBiblioteca.Entidades.Entidades;
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
    public partial class ProvinciaAEForm : MetroFramework.Forms.MetroForm
    {
        public ProvinciaAEForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (provincia != null)
            {
                ProvinciaMetroTextBox.Text = provincia.NombreProvincia;
            }
        }
        private Provincia provincia;

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal Provincia GetProvincia()
        {
            return provincia;
        }
        public void SetProvincia(Provincia provincia)
        {
            this.provincia = provincia;
        }
        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (provincia == null)
                {
                    provincia = new Provincia();
                }

                provincia.NombreProvincia = ProvinciaMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }

        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(ProvinciaMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ProvinciaMetroTextBox, "Debe ingresar una provincia");
            }

            return valido;
        }
    }
}
