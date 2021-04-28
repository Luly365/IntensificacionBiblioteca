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
        private IServiciosGenero _serviciosGenero;
        private List<SubGeneroListDto> lista;
        private void SubGeneroForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServicioSubGeneros();
            try
            {
                _servicio = new ServicioSubGeneros();
                _serviciosGenero = new ServiciosGenero();
                lista = _servicio.GetLista(null);
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
                    SubGeneroEditDto subGeneroEditDto = frm.GetSubGenero();
                    //Controlar repitencia

                    if (!_servicio.Existe(subGeneroEditDto))
                    {
                        _servicio.Guardar(subGeneroEditDto);
                        SubGeneroListDto subGeneroListDto = new SubGeneroListDto//saco los datos de SubGenero
                        {
                            SubGeneroId = subGeneroEditDto.SubGeneroId,
                            NombreSubGenero = subGeneroEditDto.NombreSubGenero,
                            NombreGenero = subGeneroEditDto.Genero.Descripcion
                        };
                        

                        
                    
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, subGeneroListDto);
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
            SubGeneroListDto subGeneroListDto = (SubGeneroListDto)r.Tag;
            SubGeneroListDto subGeneroListDtoAuxiliar = subGeneroListDto.Clone() as SubGeneroListDto;
            SubGeneroAEForm frm = new SubGeneroAEForm();
            SubGeneroEditDto subGeneroEditDto = _servicio.GetSubGeneroPorId(subGeneroListDto.SubGeneroId);
            frm.Text = "Editar SubGenero";
            frm.SetSubGenero(subGeneroEditDto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                subGeneroEditDto = frm.GetSubGenero();
                //Controlar repitencia

                if (!_servicio.Existe(subGeneroEditDto))
                {
                    _servicio.Guardar(subGeneroEditDto);
                    subGeneroListDto.SubGeneroId = subGeneroEditDto.SubGeneroId;
                    subGeneroListDto.NombreSubGenero = subGeneroEditDto.NombreSubGenero;
                    subGeneroListDto.NombreGenero = subGeneroEditDto.Genero.Descripcion;
                    
                    SetearFila(r, subGeneroListDto);
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
