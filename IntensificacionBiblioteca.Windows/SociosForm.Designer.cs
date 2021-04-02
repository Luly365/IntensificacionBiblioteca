namespace IntensificacionBiblioteca.Windows
{
    partial class SociosForm
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
            this.SociosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTelefonoFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTelefonoCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSancionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.ActualizarMetroButton = new MetroFramework.Controls.MetroButton();
            this.BorrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.EditarMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.SociosMetroGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SociosMetroGrid
            // 
            this.SociosMetroGrid.AllowUserToAddRows = false;
            this.SociosMetroGrid.AllowUserToDeleteRows = false;
            this.SociosMetroGrid.AllowUserToResizeRows = false;
            this.SociosMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SociosMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SociosMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SociosMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SociosMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SociosMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SociosMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnNombre,
            this.cmnApellido,
            this.cmnDireccion,
            this.cmnLocalidad,
            this.cmnTelefonoFijo,
            this.cmnTelefonoCel,
            this.cmnEMail,
            this.cmnSancionado,
            this.cmnActivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SociosMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SociosMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SociosMetroGrid.EnableHeadersVisualStyles = false;
            this.SociosMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SociosMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SociosMetroGrid.Location = new System.Drawing.Point(20, 84);
            this.SociosMetroGrid.Name = "SociosMetroGrid";
            this.SociosMetroGrid.ReadOnly = true;
            this.SociosMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SociosMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SociosMetroGrid.RowHeadersVisible = false;
            this.SociosMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SociosMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SociosMetroGrid.Size = new System.Drawing.Size(918, 346);
            this.SociosMetroGrid.TabIndex = 0;
            // 
            // cmnNombre
            // 
            this.cmnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnNombre.HeaderText = "Nombre";
            this.cmnNombre.Name = "cmnNombre";
            this.cmnNombre.ReadOnly = true;
            // 
            // cmnApellido
            // 
            this.cmnApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnApellido.HeaderText = "Apellido";
            this.cmnApellido.Name = "cmnApellido";
            this.cmnApellido.ReadOnly = true;
            // 
            // cmnDireccion
            // 
            this.cmnDireccion.HeaderText = "Dirección";
            this.cmnDireccion.Name = "cmnDireccion";
            this.cmnDireccion.ReadOnly = true;
            // 
            // cmnLocalidad
            // 
            this.cmnLocalidad.HeaderText = "Localidad";
            this.cmnLocalidad.Name = "cmnLocalidad";
            this.cmnLocalidad.ReadOnly = true;
            // 
            // cmnTelefonoFijo
            // 
            this.cmnTelefonoFijo.HeaderText = "Telefono Fijo";
            this.cmnTelefonoFijo.Name = "cmnTelefonoFijo";
            this.cmnTelefonoFijo.ReadOnly = true;
            // 
            // cmnTelefonoCel
            // 
            this.cmnTelefonoCel.HeaderText = "Telefono Celular";
            this.cmnTelefonoCel.Name = "cmnTelefonoCel";
            this.cmnTelefonoCel.ReadOnly = true;
            // 
            // cmnEMail
            // 
            this.cmnEMail.HeaderText = "E-Mail";
            this.cmnEMail.Name = "cmnEMail";
            this.cmnEMail.ReadOnly = true;
            // 
            // cmnSancionado
            // 
            this.cmnSancionado.HeaderText = "Sancionado";
            this.cmnSancionado.Name = "cmnSancionado";
            this.cmnSancionado.ReadOnly = true;
            // 
            // cmnActivo
            // 
            this.cmnActivo.HeaderText = "Activo";
            this.cmnActivo.Name = "cmnActivo";
            this.cmnActivo.ReadOnly = true;
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
            this.localidadesToolStripMenuItem,
            this.provinciasToolStripMenuItem,
            this.tipoDeDocumentoToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.provinciasToolStripMenuItem.Text = "Provincias";
            this.provinciasToolStripMenuItem.Click += new System.EventHandler(this.provinciasToolStripMenuItem_Click);
            // 
            // tipoDeDocumentoToolStripMenuItem
            // 
            this.tipoDeDocumentoToolStripMenuItem.Name = "tipoDeDocumentoToolStripMenuItem";
            this.tipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tipoDeDocumentoToolStripMenuItem.Text = "Tipo De Documento";
            this.tipoDeDocumentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeDocumentoToolStripMenuItem_Click);
            // 
            // SalirMetroButton
            // 
            this.SalirMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.exit_48px1;
            this.SalirMetroButton.Location = new System.Drawing.Point(357, 10);
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
            // 
            // EditarMetroButton
            // 
            this.EditarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.editar_48px;
            this.EditarMetroButton.Location = new System.Drawing.Point(183, 10);
            this.EditarMetroButton.Name = "EditarMetroButton";
            this.EditarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.EditarMetroButton.TabIndex = 3;
            this.EditarMetroButton.UseSelectable = true;
            // 
            // NuevoMetroButton
            // 
            this.NuevoMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.nuevo_48px;
            this.NuevoMetroButton.Location = new System.Drawing.Point(125, 10);
            this.NuevoMetroButton.Name = "NuevoMetroButton";
            this.NuevoMetroButton.Size = new System.Drawing.Size(52, 47);
            this.NuevoMetroButton.TabIndex = 2;
            this.NuevoMetroButton.UseSelectable = true;
            // 
            // SociosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.ActualizarMetroButton);
            this.Controls.Add(this.BorrarMetroButton);
            this.Controls.Add(this.EditarMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.SociosMetroGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SociosForm";
            this.Text = "Socios";
            ((System.ComponentModel.ISupportInitialize)(this.SociosMetroGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid SociosMetroGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton EditarMetroButton;
        private MetroFramework.Controls.MetroButton BorrarMetroButton;
        private MetroFramework.Controls.MetroButton ActualizarMetroButton;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTelefonoFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTelefonoCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSancionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnActivo;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDocumentoToolStripMenuItem;
    }
}