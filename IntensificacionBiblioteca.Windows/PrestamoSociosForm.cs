using IntensificacionBiblioteca.Entidades.DTOs.Prestamo;
using IntensificacionBiblioteca.Entidades.DTOs.Socio;
using IntensificacionBiblioteca.Servicios.Servicios;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
using IntensificacionBiblioteca.Windows.Formularios_AE;
using IntensificacionBiblioteca.Windows.Helpers;
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
    public partial class PrestamoSociosForm : MetroFramework.Forms.MetroForm
    {
        public PrestamoSociosForm()
        {
            InitializeComponent();
        }

        private IServicioPrestamos _servicio;
        private List<PrestamoListDto> _lista;

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostrarDatosEnGrilla()
        {
            PrestamoSocioMetroGrid.Rows.Clear();
            foreach (var prestamoListDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, prestamoListDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            PrestamoSocioMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, PrestamoListDto prestamoListDto)
        {
            r.Cells[cmnPrestamoNro.Index].Value = prestamoListDto.PrestamoId;
            r.Cells[cmnNombre.Index].Value = prestamoListDto.NombreSocio;
            r.Cells[cmnApellido.Index].Value = prestamoListDto.ApellidoSocio;
            r.Cells[cmnFechaPrestamo.Index].Value = prestamoListDto.FechaPrestamo.ToShortDateString();


            r.Tag = prestamoListDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(PrestamoSocioMetroGrid);
            return r;

        }

        private void LibroPrestadoMetroButton_Click(object sender, EventArgs e)
        {
            if (PrestamoSocioMetroGrid.SelectedRows.Count==0)
            {
                return;
            }
            try
            {
                DataGridViewRow r = PrestamoSocioMetroGrid.SelectedRows[0];
                var prestamoDto = (PrestamoListDto)r.Tag;
                var listaDetalle = _servicio.GetDetalle(prestamoDto.PrestamoId);
                LibrosPrestadosForm frm = new LibrosPrestadosForm();
                frm.Text = $"Prestamo Nº {prestamoDto.PrestamoId}";
                frm.SetDetalle(prestamoDto.ItemsPrestamo);
                frm.ShowDialog(this);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception);
                throw;
            }


           
            
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            PrestamoAEForm frm = new PrestamoAEForm();
            frm.Text = "Nuevo Prestamo";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    var prestamoDto = frm.GetPrestamo();
                    _servicio.Guardar(prestamoDto);
                    var prestamoListDto = new PrestamoListDto
                    {
                        PrestamoId = prestamoDto.PrestamoId,
                        NombreSocio=prestamoDto.NombreSocio.Nombre,
                        ApellidoSocio=prestamoDto.ApellidoSocio.Apellido,
                        FechaPrestamo=prestamoDto.FechaPrestamo,
                        ItemsPrestamo=Helper.ConstruirListaItemsListDto(prestamoDto.DetallePrestamo)
                       

                    };
                    var r = ConstruirFila();
                    SetearFila(r, prestamoListDto);
                    AgregarFila(r);
                    MessageBox.Show("Prestamo ", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void PrestamoSociosForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServicioPrestamo();
            try
            {
                _lista = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
