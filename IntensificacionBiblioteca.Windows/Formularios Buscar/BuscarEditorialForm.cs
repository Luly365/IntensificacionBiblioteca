using IntensificacionBiblioteca.Entidades.DTOs.Pais;
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
    public partial class BuscarEditorialForm : MetroFramework.Forms.MetroForm
    {
        public BuscarEditorialForm()
        {
            InitializeComponent();
        }
      
        private PaisListDto paisDto;
        private void BuscarEditorialForm_Load(object sender, EventArgs e)
        {
            Helper.CargarDatosComboPais(ref PaisMetroComboBox);
        }


        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       

        public PaisListDto GetPais()
        {
            return paisDto;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                paisDto = (PaisListDto)PaisMetroComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (PaisMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisMetroComboBox, "Debe seleccionar un Pais");
            }

            return valido;
        }
    }
}
