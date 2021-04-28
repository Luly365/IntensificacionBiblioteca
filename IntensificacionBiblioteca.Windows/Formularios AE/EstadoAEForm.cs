using IntensificacionBiblioteca.Entidades.DTOs.Estado;
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
    public partial class EstadoAEForm : MetroFramework.Forms.MetroForm
    {
        public EstadoAEForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (estado!= null)
            {
                EstadoMetroTextBox.Text = estado.Descripcion;
            }
        }

        
        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private EstadoEditDto estado;
        public EstadoEditDto GetEstado()
        {
            return estado;
        }
     
        

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (estado == null)
                {
                    estado = new EstadoEditDto();
                }

                estado.Descripcion = EstadoMetroTextBox.Text.Trim();//trip
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(EstadoMetroTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(EstadoMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(EstadoMetroTextBox, "Debe ingresar un Estado");
            }

            return valido;
        }

        internal void SetEstado(EstadoEditDto estado)
        {
            this.estado = estado;
        }

        private void EstadoAEForm_Load(object sender, EventArgs e)
        {

        }
    }
}
