using IntensificacionBiblioteca.Entidades.DTOs.Socio;
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
    public partial class SociosForm : MetroFramework.Forms.MetroForm
    {
        public SociosForm()
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

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinciasForm frm = new ProvinciasForm();
            frm.ShowDialog(this);
        }

        private void tipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDeDocForm frm = new TipoDeDocForm();
            frm.ShowDialog(this);
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalidadesForm frm = new LocalidadesForm();
            frm.ShowDialog(this);
        }
        private IServicioSocios _servicio;
        private List<SocioListDto> _lista;

        private void SociosForm_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioSocios();
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
            SociosMetroGrid.Rows.Clear();
            foreach (var socioListDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, socioListDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            SociosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, SocioListDto socioListDto)
        {
            r.Cells[cmnNombre.Index].Value = socioListDto.Nombre;
            r.Cells[cmnApellido.Index].Value = socioListDto.Apellido;
            r.Cells[cmnNroDoc.Index].Value = socioListDto.NroDoc;
            r.Cells[cmnDireccion.Index].Value = socioListDto.Direccion;
            r.Cells[cmnLocalidad.Index].Value = socioListDto.NombreLocalidad;
            r.Cells[cmnTelefonoFijo.Index].Value = socioListDto.TelefonoFijo;
            r.Cells[cmnTelefonoCel.Index].Value = socioListDto.TelefonoFijo;
            r.Cells[cmnEMail.Index].Value = socioListDto.CorreoElectronico;
            r.Cells[cmnSancionado.Index].Value = socioListDto.Sancionado;
            r.Cells[cmnActivo.Index].Value = socioListDto.Activo;

            r.Tag = socioListDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(SociosMetroGrid);
            return r;

        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            SocioAEForm frm = new SocioAEForm();
            frm.Text = "Agregar Socio";
            frm.ShowDialog(this);
        }
    }
}
