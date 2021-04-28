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
    public partial class frmMenuPrincipal:MetroFramework.Forms.MetroForm
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void SalirMetroTile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LibroMetroTile_Click(object sender, EventArgs e)
        {
            LibrosForm frm = new LibrosForm();
            frm.ShowDialog(this);
        }

        private void SociosMetroTile_Click(object sender, EventArgs e)
        {
            SociosForm frm = new SociosForm();
            frm.ShowDialog(this);
        }

        private void MPPaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaisForm frm = new PaisForm();
            frm.ShowDialog(this);
        }

        private void MPGenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerosForm frm = new GenerosForm();
            frm.ShowDialog(this);
        }

        private void MPProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinciasForm frm = new ProvinciasForm();
            frm.ShowDialog(this);
        }

        private void MPLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalidadesForm frm = new LocalidadesForm();
            frm.ShowDialog(this);
        }

        private void MPTiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDeDocForm frm = new TipoDeDocForm();
            frm.ShowDialog(this);
        }

        private void MPSubGenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubGeneroForm frm = new SubGeneroForm();
            frm.ShowDialog(this);
        }

        private void MPAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoresForm frm = new AutoresForm();
            frm.ShowDialog(this);
        }

        private void MPEstadoDeLosLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadosForm frm = new EstadosForm();
            frm.ShowDialog(this);
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorialesForm frm = new EditorialesForm();
            frm.ShowDialog(this);
        }

        private void autoresLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoresLibrosForm frm = new AutoresLibrosForm();
            frm.ShowDialog(this);
        }

        private void PrestamosMetroTile_Click(object sender, EventArgs e)
        {
            PrestamoSociosForm frm = new PrestamoSociosForm();
            frm.ShowDialog(this);
        }
    }
}
