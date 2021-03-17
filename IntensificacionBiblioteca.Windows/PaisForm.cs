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
    public partial class PaisForm : MetroFramework.Forms.MetroForm
    {
        public PaisForm()
        {
            InitializeComponent();
        }

        private void PaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosPais _servicio;
        private List<Pais> _lista;
        private void PaisForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosPaises();
            try
            {
                _lista = _servicio.GetPaises();
                MostrardatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void MostrardatosEnGrilla()
        {
            PaisMetroGrid.Rows.Clear();
            foreach (var pais in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, pais);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            PaisMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Pais pais)
        {
            r.Cells[cmnPais.Index].Value = pais.NombrePais;
            r.Tag = pais;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(PaisMetroGrid);
            return r;
        }
    }
}
