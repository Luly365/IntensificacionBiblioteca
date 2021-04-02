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
    public partial class GenerosForm : MetroFramework.Forms.MetroForm
    {
        public GenerosForm()
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
        private IServiciosGenero _servicio;
        private List<Genero> _lista;

        private void GenerosForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosGenero();
            try
            {
                _lista = _servicio.GetGeneros();
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
            GeneroMetroGrid.Rows.Clear();
            foreach (var genero in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, genero);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            GeneroMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Genero genero)
        {
            r.Cells[cmnGenero.Index].Value = genero.Descripcion;
            r.Tag = genero;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(GeneroMetroGrid);
            return r;
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            GeneroAEForm frm = new GeneroAEForm();
            frm.Text = "Nuevo Genero";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Genero genero = frm.GetGenero();
                    if (!_servicio.Existe(genero))
                    {
                        _servicio.Guardar(genero);//tenia agregar
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, genero);
                        AgregarFila(r);
                        MessageBox.Show("Registro Agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro Duplicado... Alta denegada", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (GeneroMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = GeneroMetroGrid.SelectedRows[0];
                Genero genero = (Genero)r.Tag;
                //ICLONEABLE
                Genero generoAuxiliar = (Genero)genero.Clone();
                GeneroAEForm frm = new GeneroAEForm();
                frm.Text = "Editar Genero";
                frm.SetGenero(genero);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        genero = frm.GetGenero();

                        if (!_servicio.Existe(genero))
                        {
                            _servicio.Guardar(genero);//es Guardar
                            SetearFila(r, genero);
                            MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            SetearFila(r, generoAuxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (GeneroMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = GeneroMetroGrid.SelectedRows[0];
                Genero genero = (Genero)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al Genero {genero.Descripcion}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {//verificar que no este relacionado
                    try
                    {
                        _servicio.Borrar(genero.GeneroId);
                        GeneroMetroGrid.Rows.Remove(r);
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
