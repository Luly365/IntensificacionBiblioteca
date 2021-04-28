using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
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
    public partial class LocalidadAEForm :MetroFramework.Forms.MetroForm
    {
        public LocalidadAEForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboProvincias(ref ProvinciasMetroComboBox);

            if (localidad!= null)
            {
                LocalidadMetroTextBox.Text = localidad.NombreLocalidad;
                ProvinciasMetroComboBox.SelectedValue = localidad.ProvinciaId;
            }
        }

        private LocalidadEditDto localidad;
        public LocalidadEditDto GetLocalidad()
        {
            return localidad;
        }
        public void SetLocalidad(LocalidadEditDto localidad)
        {
            this.localidad = localidad;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidadDatos())
            {
                if (localidad == null)
                {
                    localidad = new LocalidadEditDto();
                }

                localidad.NombreLocalidad = LocalidadMetroTextBox.Text;
                localidad.ProvinciaId = ((Provincia)ProvinciasMetroComboBox.SelectedItem).ProvinciaId;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidadDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(LocalidadMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(LocalidadMetroTextBox, "La Localidad es requerida");
            }

            if (ProvinciasMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciasMetroComboBox, "Debe seleccionar una provincia");
            }

            return valido;
        }

        private void ProvinciasMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
