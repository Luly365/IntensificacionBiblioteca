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
    public partial class AutorAEForm : MetroFramework.Forms.MetroForm
    {
        public AutorAEForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (autor != null)
            {
                AutorMetroTextBox.Text = autor.NombreAutor;
            }
        }
        private Autor autor;

        internal Autor GetAutor()
        {
            return autor;
        }

        private void OKMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (autor == null)
                {
                    autor = new Autor();
                }

                autor.NombreAutor = AutorMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(AutorMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(AutorMetroTextBox, "Debe ingresar un Autor");
            }

            return valido;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetAutor(Autor autor)
        {
            this.autor = autor;
        }

        private void AutorAEForm_Load(object sender, EventArgs e)
        {

        }
    }
}
