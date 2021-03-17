﻿using IntensificacionBiblioteca.Entidades.Entidades;
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

       
    }
}
