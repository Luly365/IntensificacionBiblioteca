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
    public partial class LibrosForm : MetroFramework.Forms.MetroForm
    {
        public LibrosForm()
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

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoresForm frm = new AutoresForm();
            frm.ShowDialog(this);
        }
    }
}
