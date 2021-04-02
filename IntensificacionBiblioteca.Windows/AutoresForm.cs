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
    public partial class AutoresForm : MetroFramework.Forms.MetroForm
    {
        public AutoresForm()
        {
            InitializeComponent();
        }

        //private void PaisesToolStripMenuItem_Click(object sender, EventArgs e)
       // {
        //    PaisForm frm = new PaisForm();
        //    frm.ShowDialog(this);
       // }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosAutor _servicio;
        private List<Autor> _lista;
        private void AutoresForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosAutor();
            try
            {
                _lista = _servicio.GetAutores();
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
            AutoresMetroGrid.Rows.Clear();
            foreach (var autor in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, autor);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            AutoresMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Autor autor)
        {
            r.Cells[cmnAutores.Index].Value = autor.NombreAutor;

            r.Tag = autor;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(AutoresMetroGrid);
            return r;
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            AutorAEForm frm = new AutorAEForm();
            frm.Text = "Nuevo Autor";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Autor autor = frm.GetAutor();
                    if (!_servicio.Existe(autor))
                    {
                        _servicio.Guardar(autor);//agregar
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, autor);
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
            if (AutoresMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = AutoresMetroGrid.SelectedRows[0];
                Autor autor = (Autor)r.Tag;

                Autor autorauxiliar = (Autor)autor.Clone();

                AutorAEForm frm = new AutorAEForm();
                frm.Text = "Editar Autor";
                frm.SetAutor(autor);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        autor = frm.GetAutor();
                        if (!_servicio.Existe(autor))
                        {
                            _servicio.Guardar(autor);
                            SetearFila(r, autor);
                            MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }

                        else
                        {
                            SetearFila(r, autorauxiliar);
                            MessageBox.Show("Registro ya existente", "Mensaje", 
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
        }

        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (AutoresMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = AutoresMetroGrid.SelectedRows[0];
                Autor autor = (Autor)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al Autor {autor.NombreAutor}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    //verificar que no este relacionado
                    try
                    {
                        _servicio.Borrar(autor.AutorId);
                        AutoresMetroGrid.Rows.Remove(r);
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
