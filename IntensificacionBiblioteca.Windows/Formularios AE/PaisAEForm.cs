using IntensificacionBiblioteca.Entidades.DTOs.Pais;
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
    public partial class PaisAEForm : MetroFramework.Forms.MetroForm
    {
        public PaisAEForm()
        {
            InitializeComponent();
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (pais != null)
            {
                PaisMetroTextBox.Text = pais.NombrePais;
            }
        }
        private PaisEditDto pais;


        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (pais == null)
                {
                    pais = new PaisEditDto();
                }

                pais.NombrePais = PaisMetroTextBox.Text; //trip
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(PaisMetroTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(PaisMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(PaisMetroTextBox, "Debe ingresar un País");
            }

            return valido;
        }

        public PaisEditDto GetPais()
        {
            return pais;
        }

        
        public void SetPais(PaisEditDto pais)
        {
            this.pais = pais;
        }

        private void PaisAEForm_Load(object sender, EventArgs e)
        {

        }
    }
}
