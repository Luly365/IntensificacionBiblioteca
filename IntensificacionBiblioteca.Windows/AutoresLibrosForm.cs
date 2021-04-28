using IntensificacionBiblioteca.Entidades.DTOs.AutorLibro;
using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using IntensificacionBiblioteca.Windows.Formularios_AE;
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
    public partial class AutoresLibrosForm : MetroFramework.Forms.MetroForm
    {
        public AutoresLibrosForm()
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
        private IServicioAutoresLibros _servicio;
        private List<AutorLibroListDto> _lista;

        private void AutoresLibrosForm_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioAutoresLibros();
                _lista = _servicio.GetLista();
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
            AutoresLibrosMetroGrid.Rows.Clear();
            foreach (var autorLibro in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, autorLibro);
                AgregarFila(r);
            }
        }



        private void AgregarFila(DataGridViewRow r)
        {
            AutoresLibrosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, AutorLibroListDto autorLibro)
        {
            r.Cells[cmnLibro.Index].Value = autorLibro.Titulo;
            r.Cells[cmnAutor.Index].Value = autorLibro.NombreAutor;
            r.Tag = autorLibro;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(AutoresLibrosMetroGrid);
            return r;
        }

        private void BuscarMetroButton_Click(object sender, EventArgs e)
        {
            //BuscarLibroForm frm = new BuscarLibroForm();
            //frm.Text = "Selecione un Libro";
            //DialogResult dr = frm.ShowDialog(this);
            //if (dr == DialogResult.Cancel)
            //{
            //    return;
            //}
            //try
            //{
            //    AutorLibroListDto autorLibro = frm.GetAutorLibro();
            //    _lista = _servicio.GetLista(autorLibro);
            //    MostrardatosEnGrilla();

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //private void MostrardatosEnGrilla()
        //{
        //    AutoresLibrosMetroGrid.Rows.Clear();
        //    foreach (var autorLibroListDto in _lista)
        //    {
        //        DataGridViewRow r = ConstruirFila();
        //        SetearFila(r, autorLibroListDto);
        //        AgregarFila(r);
        //    }
        //}
    }
}
