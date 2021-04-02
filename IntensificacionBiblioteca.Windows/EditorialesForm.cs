﻿using IntensificacionBiblioteca.Entidades.DTOs.Editorial;
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
    public partial class EditorialesForm : MetroFramework.Forms.MetroForm
    {
        public EditorialesForm()
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
        private IServicioEditoriales _servicio;
        private List<EditorialListDto> _lista;

        private void EditorialesForm_Load_1(object sender, EventArgs e)
        {
            
            try
            {
                _servicio = new ServicioEditoriales();
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
            EditorialesMetroGrid.Rows.Clear();
            foreach (var editorialDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, editorialDto);
                AgregarFila(r);
            }
        }



        private void AgregarFila(DataGridViewRow r)
        {
            EditorialesMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, EditorialListDto editorialDto)
        {
            r.Cells[cmnEditorial.Index].Value = editorialDto.NombreEditorial;
            r.Cells[cmnPais.Index].Value = editorialDto.NombrePais;
            r.Tag = editorialDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(EditorialesMetroGrid);
            return r;
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            EditorialAEForm frm = new EditorialAEForm();
            frm.Text = "Agregar Editorial";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Editorial editorial = frm.GetEditorial();
                    //Controlar repitencia

                    if (!_servicio.Existe(editorial))
                    {
                        _servicio.Guardar(editorial);
                        EditorialListDto editorialDto = new EditorialListDto
                        {
                            EditorialId = editorial.EditorialId,
                            NombreEditorial = editorial.NombreEditorial,
                            NombrePais = editorial.Pais.NombrePais
                        };
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, editorialDto);
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
            if (EditorialesMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = EditorialesMetroGrid.SelectedRows[0];
            EditorialListDto editorialDto = (EditorialListDto)r.Tag;
            DialogResult dr =
                MessageBox.Show($"¿Desea borrar la Editorial {editorialDto.NombreEditorial}?",
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
                _servicio.Borrar(editorialDto.EditorialId);
                EditorialesMetroGrid.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (EditorialesMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = EditorialesMetroGrid.SelectedRows[0];
            EditorialListDto EditorialDto = (EditorialListDto)r.Tag;
            EditorialListDto editorialListDtoAuxiliar = EditorialDto.Clone() as EditorialListDto;
            EditorialAEForm frm = new EditorialAEForm();
            Editorial editorial = _servicio.GetEditorialPorId(EditorialDto.EditorialId);
            frm.Text = "Editar Editorial";
            frm.SetEditorial(editorial);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                editorial = frm.GetEditorial();
                //Controlar repitencia

                if (!_servicio.Existe(editorial))
                {
                    _servicio.Guardar(editorial);
                    EditorialDto = new EditorialListDto
                    {
                        EditorialId = editorial.EditorialId,
                        NombreEditorial = editorial.NombreEditorial,
                        NombrePais = editorial.Pais.NombrePais
                    };
                    SetearFila(r, EditorialDto);
                    MessageBox.Show("Registro Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SetearFila(r, editorialListDtoAuxiliar);
                    MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exception)
            {
                SetearFila(r, editorialListDtoAuxiliar);

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
