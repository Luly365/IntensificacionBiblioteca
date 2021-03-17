using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
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
    public partial class AutoresForm : MetroFramework.Forms.MetroForm
    {
        public AutoresForm()
        {
            InitializeComponent();
        }

        //private void PaisesToolStripMenuItem_Click(object sender, EventArgs e)
       // {
        //    PaisForm frm = new PaisForm();
        //    frm.ShowDialog(this);
       // }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosAutor _servicio;
        private List<Autor> _lista;
        private void AutoresForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosAutor();
            try
            {
                _lista = _servicio.GetAutores();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void MostrarDatosEnGrilla()
        {
            AutoresMetroGrid.Rows.Clear();
            foreach (var autor in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, autor);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            AutoresMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Autor autor)
        {
            r.Cells[cmnAutores.Index].Value = autor.NombreAutor;

            r.Tag = autor;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(AutoresMetroGrid);
            return r;
        }
    }
}
