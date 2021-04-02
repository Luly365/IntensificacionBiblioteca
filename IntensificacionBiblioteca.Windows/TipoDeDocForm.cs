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
    public partial class TipoDeDocForm : MetroFramework.Forms.MetroForm
    {
        public TipoDeDocForm()
        {
            InitializeComponent();
        }



        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private IServiciosTipoDeDocumento _servicio;
        private List<TipoDeDocumento> _lista;
        private void TipoDeDocForm_Load(object sender, EventArgs e)
        {
            _servicio = new ServiciosTipoDeDocumento();
            try
            {
                _lista = _servicio.GetTipoDeDocumentos();
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
            TiposDeDocMetroGrid.Rows.Clear();
            foreach (var tipoDeDoc in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipoDeDoc);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            TiposDeDocMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDeDocumento tipoDeDoc)
        {
            r.Cells[cmnTipoDeDoc.Index].Value = tipoDeDoc.Descripcion;

            r.Tag = tipoDeDoc;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(TiposDeDocMetroGrid);
            return r;
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            TipoDeDocAEForm frm = new TipoDeDocAEForm();
            frm.Text = "Nuevo Tipo de Documents";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDeDocumento tipoDeDocumento = frm.GetTipoDeDoc();
                    if (!_servicio.Existe(tipoDeDocumento))
                    {
                        _servicio.Guardar(tipoDeDocumento);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, tipoDeDocumento);
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
            if (TiposDeDocMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = TiposDeDocMetroGrid.SelectedRows[0];
                TipoDeDocumento tipoDeDocumento = (TipoDeDocumento)r.Tag;

                TipoDeDocumento tipodedocAux = (TipoDeDocumento)tipoDeDocumento.Clone();
                TipoDeDocAEForm frm = new TipoDeDocAEForm();
                frm.Text = "Editar Tipo De Documento";
                frm.SetTipoDeDoc(tipoDeDocumento);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tipoDeDocumento = frm.GetTipoDeDoc();
                        if (!_servicio.Existe(tipoDeDocumento))
                        {
                            _servicio.Guardar(tipoDeDocumento);
                            SetearFila(r, tipoDeDocumento);
                            MessageBox.Show("Registro Editado", "Mensaje", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            SetearFila(r, tipodedocAux);
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
            if (TiposDeDocMetroGrid.SelectedRows.Count>0)
            {
                DataGridViewRow r = TiposDeDocMetroGrid.SelectedRows[0];
                TipoDeDocumento tipoDeDocumento = (TipoDeDocumento)r.Tag;
                DialogResult dr = MessageBox.Show(this, $"Desea dar de baja el {tipoDeDocumento.Descripcion}",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) ;

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        _servicio.Borrar(tipoDeDocumento.TipoDeDocId);
                        TiposDeDocMetroGrid.Rows.Remove(r);
                        MessageBox.Show("Registro Borrado", "Mesaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception exepcion)
                    {

                        MessageBox.Show(exepcion.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error); 
                    }
                }
            }
        }
    }
}
