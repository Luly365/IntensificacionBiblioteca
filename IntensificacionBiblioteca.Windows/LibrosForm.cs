using IntensificacionBiblioteca.Entidades.DTOs.Libro;
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
    public partial class LibrosForm : MetroFramework.Forms.MetroForm
    {
        public LibrosForm()
        {
            InitializeComponent();
        }

        private void PaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaisForm frm = new PaisForm();
            frm.ShowDialog(this);
        }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoresForm frm = new AutoresForm();
            frm.ShowDialog(this);
        }

        private void GenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerosForm frm = new GenerosForm();
            frm.ShowDialog(this);
        }

        private void EstadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstadosForm frm = new EstadosForm();
            frm.ShowDialog(this);
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorialesForm frm = new EditorialesForm();
            frm.ShowDialog(this);
        }
        private IServicioLibros _servicio;
        private List<LibroListDto> _lista;

        private void LibrosForm_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioLibros();
                _lista = _servicio.GetLista();
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
            LibroMetroGrid.Rows.Clear();
            foreach (var libroListDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, libroListDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            LibroMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, LibroListDto libroListDto)
        {
            r.Cells[cmnTitulo.Index].Value = libroListDto.Titulo;
            r.Cells[cmnISBN.Index].Value = libroListDto.ISBN;
            r.Cells[cmnEditorial.Index].Value = libroListDto.Editorial;
            r.Cells[cmnGenero.Index].Value = libroListDto.NombreGenero;
            r.Cells[cmnSubGenero.Index].Value = libroListDto.NombreSubGenero;
            r.Cells[cmnFechaIncorporacion.Index].Value = libroListDto.FechaIncorporacion.ToShortDateString();
            r.Cells[cmnEstado.Index].Value = libroListDto.DescripcionEstado;
            r.Cells[cmnObservaciones.Index].Value = libroListDto.Observaciones;
            r.Cells[cmnDisponible.Index].Value = libroListDto.Disponible;

            r.Tag = libroListDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(LibroMetroGrid);
            return r;

        }

        private void autoresLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoresLibrosForm frm = new AutoresLibrosForm();
            frm.ShowDialog(this);
        }

        private void BuscarMetroButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            LibroAEForm frm = new LibroAEForm();
            frm.Text = "Agregar Libro";
            DialogResult dr= frm.ShowDialog(this);
            if (dr== DialogResult.Cancel)
            {
                return;
            }
            try
            {
                LibroEditDto libroEditDto = frm.GetLibro();
                // controlar repetidos
                if (_servicio.Existe(libroEditDto))
                {
                    MessageBox.Show("Registro Repetido", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                //si no esta repedido lo guardamos

                _servicio.Guardar(libroEditDto);
                DataGridViewRow r = ConstruirFila();
                LibroListDto libroListDto = new LibroListDto//mapeo
                {
                    LibroId=libroEditDto.LibroId,
                    Titulo=libroEditDto.Titulo,
                    ISBN=libroEditDto.ISBN,
                    Editorial=libroEditDto.Editorial.NombreEditorial,
                    NombreGenero=libroEditDto.Genero.Descripcion,
                    NombreSubGenero=libroEditDto.SubGenero.NombreSubGenero,
                    FechaIncorporacion=libroEditDto.FechaIncorporacion,
                    DescripcionEstado=libroEditDto.Estado.Descripcion,
                    Observaciones=libroEditDto.Observaciones,
                    Disponible=libroEditDto.Disponible
                };

                SetearFila(r, libroListDto);
                AgregarFila(r);
                MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (LibroMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = LibroMetroGrid.SelectedRows[0];
            LibroListDto libroListDto = (LibroListDto)r.Tag;
            LibroListDto libroListDtoAuxiliar = (LibroListDto)libroListDto.Clone();
            LibroAEForm frm = new LibroAEForm();
            LibroEditDto libroEditDto = _servicio.GetLibroPorId(libroListDto.LibroId);
            frm.Text = "Editar Libro";
            frm.SetLibro(libroEditDto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                libroEditDto = frm.GetLibro();
                //Controlar repitencia

                if (!_servicio.Existe(libroEditDto))
                {
                    _servicio.Guardar(libroEditDto);

                    libroEditDto.LibroId = libroEditDto.LibroId;
                    libroListDto.Titulo = libroEditDto.Titulo;
                    libroListDto.ISBN = libroEditDto.ISBN;
                    libroListDto.Editorial = libroEditDto.Editorial.NombreEditorial;
                    libroListDto.NombreGenero = libroEditDto.Genero.Descripcion;
                    libroListDto.NombreSubGenero = libroEditDto.SubGenero.NombreSubGenero;
                    libroListDto.FechaIncorporacion = libroEditDto.FechaIncorporacion;
                    libroListDto.DescripcionEstado = libroEditDto.Estado.Descripcion;
                    libroListDto.Observaciones = libroEditDto.Observaciones;
                    libroListDto.Disponible = libroEditDto.Disponible;
                    SetearFila(r, libroListDto);
                    MessageBox.Show("Registro Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SetearFila(r, libroListDtoAuxiliar);
                    MessageBox.Show("Registro ya existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exception)
            {
                SetearFila(r, libroListDtoAuxiliar);

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (LibroMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = LibroMetroGrid.SelectedRows[0];
            LibroListDto libroListDto = (LibroListDto)r.Tag;
            LibroListDto libroListDtoAux = (LibroListDto)libroListDto.Clone();
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el Libro {libroListDto.Titulo}?",
                "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                _servicio.Borrar(libroListDto.LibroId);
                LibroMetroGrid.Rows.Remove(r);
                MessageBox.Show("Registro Borrado", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
