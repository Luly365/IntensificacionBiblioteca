using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
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
    public partial class BuscarLocalidadesForm : MetroFramework.Forms.MetroForm
    {
        public BuscarLocalidadesForm()
        {
            InitializeComponent();
        }
        private void BuscarLocalidadesForm_Load(object sender, EventArgs e)
        {
            Helper.CargarDatosComboProvincias(ref ProvinciasMetroComboBox);
        }
        private Provincia provincia;

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                provincia = (Provincia)ProvinciasMetroComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (ProvinciasMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciasMetroComboBox, "Debe seleccionar una Provincia");
            }

            return valido;
        }

        public Provincia GetProvincia()
        {
            return provincia;
        }
    }
}
