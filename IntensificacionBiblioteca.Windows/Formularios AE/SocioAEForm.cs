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
    public partial class SocioAEForm : MetroFramework.Forms.MetroForm
    {
        public SocioAEForm()
        {
            InitializeComponent();
        }

        //private SocioEditDto socioEditDto;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboProvincias(ref LocalidadMetroComboBox);
        }



        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {

        }

        //private void LocalidadMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ProvinciaMetroComboBox.SelectedIndex!=0)
        //    {
        //        Provincia provincia = (Provincia)ProvinciaMetroComboBox.SelectedItem;//seleccione mi provincia
        //        Helper.CargarComboLocalidades(ref LocalidadMetroComboBox, provincia);
        //    }
        //    else
        //    {
        //        LocalidadMetroComboBox.DataSource = null;
        //    }
        //}
    }
}
