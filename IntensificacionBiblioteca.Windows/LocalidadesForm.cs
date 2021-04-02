using IntensificacionBiblioteca.Entidades.DTOs.Localidad;
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
    public partial class LocalidadesForm : MetroFramework.Forms.MetroForm
    {
        public LocalidadesForm()
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
        private IServicioLocalidades _servicio;
        private List<LocalidadListDto> _lista;
        private void PaisForm_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioLocalidades();
                _lista = _servicio.GetLista();
                MostrardatosEnGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrardatosEnGrilla()
        {
            LocalidadesMetroGrid.Rows.Clear();
            foreach (var localidadListDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, localidadListDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            LocalidadesMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, LocalidadListDto localidadListDto)
        {
            r.Cells[cmnLocalidad.Index].Value = localidadListDto.NombreLocalidad;
            r.Cells[cmnProvincia.Index].Value = localidadListDto.NombreProvincia;
            r.Tag = localidadListDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(LocalidadesMetroGrid);
            return r;
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            LocalidadAEForm frm = new LocalidadAEForm();
            frm.Text = "Agregar Localidad";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Localidad localidad = frm.GetLocalidad();
                    //Controlar repitencia

                    if (!_servicio.Existe(localidad))
                    {
                        _servicio.Guardar(localidad);
                        LocalidadListDto localidadDto = new LocalidadListDto
                        {
                            LocalidadId = localidad.LocalidadId,
                            NombreLocalidad = localidad.NombreLocalidad,
                            NombreProvincia = localidad.provincia.NombreProvincia
                        };
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, localidadDto);
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
            if (LocalidadesMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = LocalidadesMetroGrid.SelectedRows[0];
            LocalidadListDto localidadDto = (LocalidadListDto)r.Tag;
            DialogResult dr =
                MessageBox.Show($"¿Desea borrar la Localidad {localidadDto.NombreLocalidad}?",
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
                _servicio.Borrar(localidadDto.LocalidadId);
                LocalidadesMetroGrid.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (LocalidadesMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = LocalidadesMetroGrid.SelectedRows[0];
            LocalidadListDto localidadDto = (LocalidadListDto)r.Tag;
            LocalidadListDto localidadListDtoAuxiliar = localidadDto.Clone() as LocalidadListDto;
            LocalidadAEForm frm = new LocalidadAEForm();
           Localidad localidad = _servicio.GetLocalidadPorId(localidadDto.LocalidadId);
            frm.Text = "Editar localidad";
            frm.SetLocalidad(localidad);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                localidad = frm.GetLocalidad();
                //Controlar repitencia

                if (!_servicio.Existe(localidad))
                {
                    _servicio.Guardar(localidad);
                    localidadDto = new LocalidadListDto
                    {
                        LocalidadId = localidad.LocalidadId,
                        NombreLocalidad = localidad.NombreLocalidad,
                        NombreProvincia = localidad.provincia.NombreProvincia
                    };
                    SetearFila(r, localidadDto);
                    MessageBox.Show("Registro Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SetearFila(r, localidadListDtoAuxiliar);
                    MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exception)
            {
                SetearFila(r, localidadListDtoAuxiliar);

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
