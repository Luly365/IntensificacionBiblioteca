using IntensificacionBiblioteca.Entidades.DTOs.DetallePrestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Libro;
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
    public partial class LibrosPrestadosForm : MetroFramework.Forms.MetroForm
    {
        public LibrosPrestadosForm()
        {
            InitializeComponent();
        }

        
        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LibroPrestamosMetroGrid.Rows.Clear();
            MostrarDatosEnGrilla();
            //deberia sumar los libros? 

        }

        private List<DetallePrestamoListDto> _lista;

        public void SetDetalle(List<DetallePrestamoListDto> listaDetalle)
        {
            _lista = listaDetalle;
        }


        
        private void MostrarDatosEnGrilla()
        {
            LibroPrestamosMetroGrid.Rows.Clear();
            foreach (var detallePrestamoListDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, detallePrestamoListDto);
                AgregarFila(r);
            }
        }

        private void SetearFila(DataGridViewRow r, DetallePrestamoListDto detallePrestamoListDto)
        {
            r.Cells[cmnTitulo.Index].Value = detallePrestamoListDto.Titulo;
            r.Cells[cmnISBN.Index].Value = detallePrestamoListDto.ISBN;
            r.Cells[cmnEstado.Index].Value = detallePrestamoListDto.Observaciones;
            //tengo en DetalleListDto "cantidad"
        }

        private void AgregarFila(DataGridViewRow r)
        {
            LibroPrestamosMetroGrid.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(LibroPrestamosMetroGrid);
            return r;
        }

        private void LibrosPrestadosForm_Load(object sender, EventArgs e)
        {

        }

        private void DevolverMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"¿Desea Devolver el Libro seleccionado?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            try
            {
                //servicioPrestamos.DevolverLibro(prestamodto);//hice met en servicio prestamos
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
