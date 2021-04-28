namespace IntensificacionBiblioteca.Windows
{
    partial class PrestamoSociosForm
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
            this.PrestamoSocioMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnPrestamoNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.DetalleLibrosPrestadosMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoSocioMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PrestamoSocioMetroGrid
            // 
            this.PrestamoSocioMetroGrid.AllowUserToAddRows = false;
            this.PrestamoSocioMetroGrid.AllowUserToDeleteRows = false;
            this.PrestamoSocioMetroGrid.AllowUserToResizeColumns = false;
            this.PrestamoSocioMetroGrid.AllowUserToResizeRows = false;
            this.PrestamoSocioMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PrestamoSocioMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrestamoSocioMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PrestamoSocioMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrestamoSocioMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PrestamoSocioMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamoSocioMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnPrestamoNro,
            this.cmnNombre,
            this.cmnApellido,
            this.cmnFechaPrestamo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrestamoSocioMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrestamoSocioMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrestamoSocioMetroGrid.EnableHeadersVisualStyles = false;
            this.PrestamoSocioMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PrestamoSocioMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PrestamoSocioMetroGrid.Location = new System.Drawing.Point(20, 60);
            this.PrestamoSocioMetroGrid.Name = "PrestamoSocioMetroGrid";
            this.PrestamoSocioMetroGrid.ReadOnly = true;
            this.PrestamoSocioMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrestamoSocioMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PrestamoSocioMetroGrid.RowHeadersVisible = false;
            this.PrestamoSocioMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PrestamoSocioMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrestamoSocioMetroGrid.Size = new System.Drawing.Size(641, 259);
            this.PrestamoSocioMetroGrid.TabIndex = 0;
            // 
            // cmnPrestamoNro
            // 
            this.cmnPrestamoNro.HeaderText = "Prestamo N°";
            this.cmnPrestamoNro.Name = "cmnPrestamoNro";
            this.cmnPrestamoNro.ReadOnly = true;
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
            // cmnFechaPrestamo
            // 
            this.cmnFechaPrestamo.HeaderText = "Fecha Prestamo";
            this.cmnFechaPrestamo.Name = "cmnFechaPrestamo";
            this.cmnFechaPrestamo.ReadOnly = true;
            // 
            // SalirMetroButton
            // 
            this.SalirMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.exit_48px1;
            this.SalirMetroButton.Location = new System.Drawing.Point(606, 7);
            this.SalirMetroButton.Name = "SalirMetroButton";
            this.SalirMetroButton.Size = new System.Drawing.Size(52, 47);
            this.SalirMetroButton.TabIndex = 6;
            this.SalirMetroButton.UseSelectable = true;
            this.SalirMetroButton.Click += new System.EventHandler(this.SalirMetroButton_Click);
            // 
            // DetalleLibrosPrestadosMetroButton
            // 
            this.DetalleLibrosPrestadosMetroButton.Location = new System.Drawing.Point(386, 10);
            this.DetalleLibrosPrestadosMetroButton.Name = "DetalleLibrosPrestadosMetroButton";
            this.DetalleLibrosPrestadosMetroButton.Size = new System.Drawing.Size(156, 44);
            this.DetalleLibrosPrestadosMetroButton.TabIndex = 9;
            this.DetalleLibrosPrestadosMetroButton.Text = "Detalle Libros Prestados";
            this.DetalleLibrosPrestadosMetroButton.UseSelectable = true;
            this.DetalleLibrosPrestadosMetroButton.Click += new System.EventHandler(this.LibroPrestadoMetroButton_Click);
            // 
            // NuevoMetroButton
            // 
            this.NuevoMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.nuevo_48px;
            this.NuevoMetroButton.Location = new System.Drawing.Point(548, 10);
            this.NuevoMetroButton.Name = "NuevoMetroButton";
            this.NuevoMetroButton.Size = new System.Drawing.Size(52, 44);
            this.NuevoMetroButton.TabIndex = 10;
            this.NuevoMetroButton.UseSelectable = true;
            this.NuevoMetroButton.Click += new System.EventHandler(this.NuevoMetroButton_Click);
            // 
            // PrestamoSociosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 339);
            this.ControlBox = false;
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.DetalleLibrosPrestadosMetroButton);
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.PrestamoSocioMetroGrid);
            this.Name = "PrestamoSociosForm";
            this.Text = "Prestamos a Socios";
            this.Load += new System.EventHandler(this.PrestamoSociosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoSocioMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid PrestamoSocioMetroGrid;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private MetroFramework.Controls.MetroButton DetalleLibrosPrestadosMetroButton;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPrestamoNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaPrestamo;
    }
}