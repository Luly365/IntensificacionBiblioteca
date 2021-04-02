using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntensificacionBiblioteca.Windows
{
    public partial class SociosForm : MetroFramework.Forms.MetroForm
    {
        public SociosForm()
        {
            InitializeComponent();
        }

        private void PaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaisForm frm = new PaisForm();
            frm.ShowDialog(this);
        }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinciasForm frm = new ProvinciasForm();
            frm.ShowDialog(this);
        }

        private void tipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDeDocForm frm = new TipoDeDocForm();
            frm.ShowDialog(this);
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalidadesForm frm = new LocalidadesForm();
            frm.ShowDialog(this);
        }
    }
}
