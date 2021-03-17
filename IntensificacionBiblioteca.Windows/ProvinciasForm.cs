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
    public partial class ProvinciasForm : MetroFramework.Forms.MetroForm
    {
        public ProvinciasForm()
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
        private IServiciosProvincia _servicio;
        private List<Provincia> _lista;
        private void ProvinciasForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosProvincias();
            try
            {
                _lista = _servicio.GetProvincias();
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
            ProvinciaMetroGrid.Rows.Clear();
            foreach (var provincia in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, provincia);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            ProvinciaMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Provincia provincia)
        {
            r.Cells[cmnProvincia.Index].Value = provincia.NombreProvincia;

            r.Tag = provincia;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(ProvinciaMetroGrid);
            return r;
        }
    }

}
