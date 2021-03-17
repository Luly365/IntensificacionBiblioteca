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
    }
}
