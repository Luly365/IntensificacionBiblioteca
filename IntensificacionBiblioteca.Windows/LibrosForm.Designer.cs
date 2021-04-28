namespace IntensificacionBiblioteca.Windows
{
    partial class LibrosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LibroMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSubGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaIncorporacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDisponible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.ActualizarMetroButton = new MetroFramework.Controls.MetroButton();
            this.BorrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.EditarMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            this.BuscarMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.LibroMetroGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibroMetroGrid
            // 
            this.LibroMetroGrid.AllowUserToAddRows = false;
            this.LibroMetroGrid.AllowUserToDeleteRows = false;
            this.LibroMetroGrid.AllowUserToResizeRows = false;
            this.LibroMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LibroMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibroMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LibroMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibroMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LibroMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibroMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTitulo,
            this.cmnISBN,
            this.cmnEditorial,
            this.cmnGenero,
            this.cmnSubGenero,
            this.cmnFechaIncorporacion,
            this.cmnEstado,
            this.cmnObservaciones,
            this.cmnDisponible});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LibroMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.LibroMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibroMetroGrid.EnableHeadersVisualStyles = false;
            this.LibroMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LibroMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LibroMetroGrid.Location = new System.Drawing.Point(20, 84);
            this.LibroMetroGrid.Name = "LibroMetroGrid";
            this.LibroMetroGrid.ReadOnly = true;
            this.LibroMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibroMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LibroMetroGrid.RowHeadersVisible = false;
            this.LibroMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LibroMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibroMetroGrid.Size = new System.Drawing.Size(918, 346);
            this.LibroMetroGrid.TabIndex = 0;
            // 
            // cmnTitulo
            // 
            this.cmnTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTitulo.HeaderText = "Titulo";
            this.cmnTitulo.Name = "cmnTitulo";
            this.cmnTitulo.ReadOnly = true;
            // 
            // cmnISBN
            // 
            this.cmnISBN.HeaderText = "ISBN";
            this.cmnISBN.Name = "cmnISBN";
            this.cmnISBN.ReadOnly = true;
            // 
            // cmnEditorial
            // 
            this.cmnEditorial.HeaderText = "Editorial";
            this.cmnEditorial.Name = "cmnEditorial";
            this.cmnEditorial.ReadOnly = true;
            // 
            // cmnGenero
            // 
            this.cmnGenero.HeaderText = "Genero";
            this.cmnGenero.Name = "cmnGenero";
            this.cmnGenero.ReadOnly = true;
            // 
            // cmnSubGenero
            // 
            this.cmnSubGenero.HeaderText = "SubGenero";
            this.cmnSubGenero.Name = "cmnSubGenero";
            this.cmnSubGenero.ReadOnly = true;
            // 
            // cmnFechaIncorporacion
            // 
            this.cmnFechaIncorporacion.HeaderText = "Fecha Incorporacion";
            this.cmnFechaIncorporacion.Name = "cmnFechaIncorporacion";
            this.cmnFechaIncorporacion.ReadOnly = true;
            // 
            // cmnEstado
            // 
            this.cmnEstado.HeaderText = "Estado";
            this.cmnEstado.Name = "cmnEstado";
            this.cmnEstado.ReadOnly = true;
            // 
            // cmnObservaciones
            // 
            this.cmnObservaciones.HeaderText = "Observaciones";
            this.cmnObservaciones.Name = "cmnObservaciones";
            this.cmnObservaciones.ReadOnly = true;
            // 
            // cmnDisponible
            // 
            this.cmnDisponible.HeaderText = "Disponible";
            this.cmnDisponible.Name = "cmnDisponible";
            this.cmnDisponible.ReadOnly = true;
            this.cmnDisponible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmnDisponible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaisesToolStripMenuItem,
            this.GenerosToolStripMenuItem,
            this.EstadosToolStripMenuItem1,
            this.AutoresToolStripMenuItem,
            this.editorialesToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // PaisesToolStripMenuItem
            // 
            this.PaisesToolStripMenuItem.Name = "PaisesToolStripMenuItem";
            this.PaisesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.PaisesToolStripMenuItem.Text = "Paises";
            this.PaisesToolStripMenuItem.Click += new System.EventHandler(this.PaisesToolStripMenuItem_Click);
            // 
            // GenerosToolStripMenuItem
            // 
            this.GenerosToolStripMenuItem.Name = "GenerosToolStripMenuItem";
            this.GenerosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.GenerosToolStripMenuItem.Text = "Generos";
            this.GenerosToolStripMenuItem.Click += new System.EventHandler(this.GenerosToolStripMenuItem_Click);
            // 
            // EstadosToolStripMenuItem1
            // 
            this.EstadosToolStripMenuItem1.Name = "EstadosToolStripMenuItem1";
            this.EstadosToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.EstadosToolStripMenuItem1.Text = "Estados";
            this.EstadosToolStripMenuItem1.Click += new System.EventHandler(this.EstadosToolStripMenuItem1_Click);
            // 
            // AutoresToolStripMenuItem
            // 
            this.AutoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresLibrosToolStripMenuItem});
            this.AutoresToolStripMenuItem.Name = "AutoresToolStripMenuItem";
            this.AutoresToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AutoresToolStripMenuItem.Text = "Autores";
            this.AutoresToolStripMenuItem.Click += new System.EventHandler(this.AutoresToolStripMenuItem_Click);
            // 
            // autoresLibrosToolStripMenuItem
            // 
            this.autoresLibrosToolStripMenuItem.Name = "autoresLibrosToolStripMenuItem";
            this.autoresLibrosToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.autoresLibrosToolStripMenuItem.Text = "AutoresLibros";
            this.autoresLibrosToolStripMenuItem.Click += new System.EventHandler(this.autoresLibrosToolStripMenuItem_Click);
            // 
            // editorialesToolStripMenuItem
            // 
            this.editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            this.editorialesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editorialesToolStripMenuItem.Text = "Editoriales";
            this.editorialesToolStripMenuItem.Click += new System.EventHandler(this.editorialesToolStripMenuItem_Click);
            // 
            // SalirMetroButton
            // 
            this.SalirMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.exit_48px1;
            this.SalirMetroButton.Location = new System.Drawing.Point(415, 10);
            this.SalirMetroButton.Name = "SalirMetroButton";
            this.SalirMetroButton.Size = new System.Drawing.Size(52, 47);
            this.SalirMetroButton.TabIndex = 6;
            this.SalirMetroButton.UseSelectable = true;
            this.SalirMetroButton.Click += new System.EventHandler(this.SalirMetroButton_Click);
            // 
            // ActualizarMetroButton
            // 
            this.ActualizarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.actualizar_48px;
            this.ActualizarMetroButton.Location = new System.Drawing.Point(299, 10);
            this.ActualizarMetroButton.Name = "ActualizarMetroButton";
            this.ActualizarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.ActualizarMetroButton.TabIndex = 5;
            this.ActualizarMetroButton.UseSelectable = true;
            // 
            // BorrarMetroButton
            // 
            this.BorrarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.BorrarMetroButton.Location = new System.Drawing.Point(241, 10);
            this.BorrarMetroButton.Name = "BorrarMetroButton";
            this.BorrarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.BorrarMetroButton.TabIndex = 4;
            this.BorrarMetroButton.UseSelectable = true;
            this.BorrarMetroButton.Click += new System.EventHandler(this.BorrarMetroButton_Click);
            // 
            // EditarMetroButton
            // 
            this.EditarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.editar_48px;
            this.EditarMetroButton.Location = new System.Drawing.Point(183, 10);
            this.EditarMetroButton.Name = "EditarMetroButton";
            this.EditarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.EditarMetroButton.TabIndex = 3;
            this.EditarMetroButton.UseSelectable = true;
            this.EditarMetroButton.Click += new System.EventHandler(this.EditarMetroButton_Click);
            // 
            // NuevoMetroButton
            // 
            this.NuevoMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.nuevo_48px;
            this.NuevoMetroButton.Location = new System.Drawing.Point(125, 10);
            this.NuevoMetroButton.Name = "NuevoMetroButton";
            this.NuevoMetroButton.Size = new System.Drawing.Size(52, 47);
            this.NuevoMetroButton.TabIndex = 2;
            this.NuevoMetroButton.UseSelectable = true;
            this.NuevoMetroButton.Click += new System.EventHandler(this.NuevoMetroButton_Click);
            // 
            // BuscarMetroButton
            // 
            this.BuscarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.Buscar_48px;
            this.BuscarMetroButton.Location = new System.Drawing.Point(357, 10);
            this.BuscarMetroButton.Name = "BuscarMetroButton";
            this.BuscarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.BuscarMetroButton.TabIndex = 7;
            this.BuscarMetroButton.UseSelectable = true;
            this.BuscarMetroButton.Click += new System.EventHandler(this.BuscarMetroButton_Click);
            // 
            // LibrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BuscarMetroButton);
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.ActualizarMetroButton);
            this.Controls.Add(this.BorrarMetroButton);
            this.Controls.Add(this.EditarMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.LibroMetroGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LibrosForm";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.LibrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibroMetroGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid LibroMetroGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EstadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AutoresToolStripMenuItem;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton EditarMetroButton;
        private MetroFramework.Controls.MetroButton BorrarMetroButton;
        private MetroFramework.Controls.MetroButton ActualizarMetroButton;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresLibrosToolStripMenuItem;
        private MetroFramework.Controls.MetroButton BuscarMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSubGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaIncorporacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnObservaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmnDisponible;
    }
}