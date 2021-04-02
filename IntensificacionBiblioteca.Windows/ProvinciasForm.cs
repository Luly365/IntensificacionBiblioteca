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

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            ProvinciaAEForm frm = new ProvinciaAEForm();
            frm.Text = "Agregar Provincias";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Provincia provincia = frm.GetProvincia();
                    if (!_servicio.Existe(provincia))
                    {
                        _servicio.Guardar(provincia);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, provincia);
                        AgregarFila(r);
                        MessageBox.Show("Registro agregado", "Mensaje",
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
            if (ProvinciaMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = ProvinciaMetroGrid.SelectedRows[0];
                Provincia p = (Provincia)r.Tag;
                //ICloneable
                Provincia provAuxiliar = (Provincia)p.Clone();

                ProvinciaAEForm frm = new ProvinciaAEForm();
                frm.Text = "Editar Provincia";
                frm.SetProvincia(p);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        p = frm.GetProvincia();
                        if (!_servicio.Existe(p))
                        {
                            _servicio.Guardar(p);
                            SetearFila(r, p);
                            MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            SetearFila(r, provAuxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
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
            if (ProvinciaMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = ProvinciaMetroGrid.SelectedRows[0];
                Provincia provincia = (Provincia)r.Tag;

                DialogResult dr = MessageBox.Show($"¿Desea borrar de la lista a {provincia.NombreProvincia}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        _servicio.Borrar(provincia.ProvinciaId);
                        ProvinciaMetroGrid.Rows.Remove(r);
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


