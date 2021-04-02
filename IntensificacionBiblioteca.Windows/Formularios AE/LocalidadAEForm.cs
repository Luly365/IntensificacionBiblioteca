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
            CargarDatosComboProvincias();

            if (localidad!= null)
            {
                LocalidadMetroTextBox.Text = localidad.NombreLocalidad;
                ProvinciasMetroComboBox.SelectedValue = localidad.provincia.ProvinciaId;
            }
        }

        private void CargarDatosComboProvincias()
        {//cargo las provincias en el ComboBox
            IServiciosProvincia _servicioProvincia = new ServiciosProvincias();
            var lista = _servicioProvincia.GetProvincias();
            var defaultProvincia = new Provincia
            {
                ProvinciaId = 0,
                NombreProvincia = "Seleccione Provincia"
            };
            lista.Insert(0, defaultProvincia);
            ProvinciasMetroComboBox.DataSource = lista;
            ProvinciasMetroComboBox.ValueMember = "ProvinciaId";
            ProvinciasMetroComboBox.DisplayMember = "NombreProvincia";
            ProvinciasMetroComboBox.SelectedIndex = 0;
        }

        private Localidad localidad;
        public Localidad GetLocalidad()
        {
            return localidad;
        }
        public void SetLocalidad(Localidad localidad)
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
                    localidad = new Localidad();
                }

                localidad.NombreLocalidad = LocalidadMetroTextBox.Text;
                localidad.provincia = (Provincia)ProvinciasMetroComboBox.SelectedItem;
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
    }
}
