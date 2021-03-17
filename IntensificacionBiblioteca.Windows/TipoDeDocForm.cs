using IntensificacionBiblioteca.Entidades.Entidades;
using IntensificacionBiblioteca.Servicios.Servicios;
using IntensificacionBiblioteca.Servicios.Servicios.Facades;
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
    }
}
