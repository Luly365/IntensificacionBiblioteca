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
    public partial class TipoDeDocAEForm : MetroFramework.Forms.MetroForm
    {
        public TipoDeDocAEForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDeDocumento != null)
            {
                TipoDeDocMetroTextBox.Text = tipoDeDocumento.Descripcion;
            }
        }
        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal TipoDeDocumento GetTipoDeDoc()
        {
            return tipoDeDocumento;
        }
        private TipoDeDocumento tipoDeDocumento;
        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeDocumento == null)
                {
                    tipoDeDocumento = new TipoDeDocumento();
                }

                tipoDeDocumento.Descripcion = TipoDeDocMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(TipoDeDocMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TipoDeDocMetroTextBox, "Debe ingresar un tipo de documento");
            }

            return valido;
        }
        public void SetTipoDeDoc(TipoDeDocumento tipoDeDocumento)
        {
            this.tipoDeDocumento = tipoDeDocumento;
        }
    }
}
