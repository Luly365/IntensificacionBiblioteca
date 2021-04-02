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
    public partial class EstadosForm : MetroFramework.Forms.MetroForm
    {
        public EstadosForm()
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
        private IServiciosEstado _servicio;
        private List<Estado> _lista;

        

        private void MostrarDatosEnGrilla()
        {
            EstadoMetroGrid.Rows.Clear();
            foreach (var estado in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, estado);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            EstadoMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Estado estado)
        {
            r.Cells[cmnEstado.Index].Value = estado.Descripcion;
            r.Tag = estado;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(EstadoMetroGrid);
            return r;
        }

        private void EstadosForm_Load_1(object sender, EventArgs e)
        {
            _servicio = new ServiciosEstado();
            try
            {
                _lista = _servicio.GetEstados();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            EstadoAEForm frm = new EstadoAEForm();
            frm.Text = "Nuevo Estado";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Estado estado = frm.GetEstado();
                    if (!_servicio.Existe(estado))
                    {
                        _servicio.Guardar(estado);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, estado);
                        AgregarFila(r);
                        MessageBox.Show(this, $"Registro {estado.Descripcion} Agregado",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro Duplicado... Alta denegada", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (EstadoMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = EstadoMetroGrid.SelectedRows[0];
                Estado estado = (Estado)r.Tag;
               
                Estado estadoAux = (Estado)estado.Clone();
                EstadoAEForm frm = new EstadoAEForm();
                frm.Text = "Editar Estado";
                frm.SetEstado(estado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        estado = frm.GetEstado();
                        if (!_servicio.Existe(estado))
                        {
                            _servicio.Guardar(estado);
                            SetearFila(r, estado);
                            MessageBox.Show($"Registro Editado","Mesaje", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            SetearFila(r, estadoAux);
                            MessageBox.Show($"Registro ya existente", "Mesaje", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception exepcion)
                    {
                        MessageBox.Show(exepcion.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (EstadoMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = EstadoMetroGrid.SelectedRows[0];
                Estado estado = (Estado)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja el estado {estado.Descripcion}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {//verificar que no este relacionado
                    try
                    {
                        _servicio.Borrar(estado.EstadoId);
                        EstadoMetroGrid.Rows.Remove(r);
                        MessageBox.Show("Registro Borrado", "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception exepcion)
                    {
                        MessageBox.Show(exepcion.Message, @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
