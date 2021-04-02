using IntensificacionBiblioteca.Entidades.DTOs.SubGenero;
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
    public partial class SubGeneroForm : MetroFramework.Forms.MetroForm
    {
        public SubGeneroForm()
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


        private IServiciosSubGeneros _servicio;
        private List<SubGeneroListDto> lista;
        private void SubGeneroForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServicioSubGeneros();
            try
            {
                lista = _servicio.GetLista();
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
            SubGeneroMetroGrid.Rows.Clear();
            foreach (var subGeneroListDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, subGeneroListDto);
                AgregarFila(r);
            }
        }
        private void AgregarFila(DataGridViewRow r)
        {
            SubGeneroMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, SubGeneroListDto subGeneroListDto)
        {
            r.Cells[cmnSubGenero.Index].Value = subGeneroListDto.NombreSubGenero;
            r.Cells[cmnGenero.Index].Value = subGeneroListDto.NombreGenero;

            r.Tag = subGeneroListDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(SubGeneroMetroGrid);
            return r;
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            SubGeneroAEForm frm = new SubGeneroAEForm();
            frm.Text = "Agregar SubGenero";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    SubGenero subGenero = frm.GetSubGenero();
                    //Controlar repitencia

                    if (!_servicio.Existe(subGenero))
                    {
                        _servicio.Guardar(subGenero);
                        SubGeneroListDto SubGeneroDto = new SubGeneroListDto
                        {//saco los datos de SubGenero
                            SubGeneroId = subGenero.SubGeneroId,
                            NombreSubGenero = subGenero.NombreSubGenero,
                            NombreGenero = subGenero.genero.Descripcion//nombregenero?
                        };
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, SubGeneroDto);
                        AgregarFila(r);
                        MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (SubGeneroMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = SubGeneroMetroGrid.SelectedRows[0];
            SubGeneroListDto subGeneroDto = (SubGeneroListDto)r.Tag;
            DialogResult dr =
                MessageBox
                    .Show($@"¿Desea borrar el SubGenero {subGeneroDto.NombreSubGenero}?",
                        "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    );
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                //Controlar relaciones 
                _servicio.Borrar(subGeneroDto.SubGeneroId);
                SubGeneroMetroGrid.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (SubGeneroMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = SubGeneroMetroGrid.SelectedRows[0];
            SubGeneroListDto subGeneroDto = (SubGeneroListDto)r.Tag;
            SubGeneroListDto subGeneroListDtoAuxiliar = subGeneroDto.Clone() as SubGeneroListDto;
            SubGeneroAEForm frm = new SubGeneroAEForm();
            SubGenero subGenero = _servicio.GetSubGeneroPorId(subGeneroDto.SubGeneroId);
            frm.Text = "Editar SubGenero";
            frm.SetSubGenero(subGenero);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                subGenero = frm.GetSubGenero();
                //Controlar repitencia

                if (!_servicio.Existe(subGenero))
                {
                    _servicio.Guardar(subGenero);
                    subGeneroDto = new SubGeneroListDto
                    {
                        SubGeneroId = subGenero.SubGeneroId,
                        NombreSubGenero = subGenero.NombreSubGenero,
                        NombreGenero = subGenero.genero.Descripcion
                    };
                    SetearFila(r, subGeneroDto);
                    MessageBox.Show("Registro Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SetearFila(r, subGeneroListDtoAuxiliar);
                    MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exception)
            {
                SetearFila(r, subGeneroListDtoAuxiliar);

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
