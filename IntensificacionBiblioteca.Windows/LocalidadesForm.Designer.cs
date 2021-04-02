namespace IntensificacionBiblioteca.Windows
{
    partial class LocalidadesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LocalidadesMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.ActualizarMetroButton = new MetroFramework.Controls.MetroButton();
            this.BorrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.EditarMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalidadesMetroGrid
            // 
            this.LocalidadesMetroGrid.AllowUserToAddRows = false;
            this.LocalidadesMetroGrid.AllowUserToDeleteRows = false;
            this.LocalidadesMetroGrid.AllowUserToResizeRows = false;
            this.LocalidadesMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LocalidadesMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalidadesMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LocalidadesMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalidadesMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LocalidadesMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalidadesMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnLocalidad,
            this.cmnProvincia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalidadesMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.LocalidadesMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalidadesMetroGrid.EnableHeadersVisualStyles = false;
            this.LocalidadesMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LocalidadesMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LocalidadesMetroGrid.Location = new System.Drawing.Point(20, 60);
            this.LocalidadesMetroGrid.Name = "LocalidadesMetroGrid";
            this.LocalidadesMetroGrid.ReadOnly = true;
            this.LocalidadesMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalidadesMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LocalidadesMetroGrid.RowHeadersVisible = false;
            this.LocalidadesMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalidadesMetroGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.LocalidadesMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalidadesMetroGrid.Size = new System.Drawing.Size(501, 370);
            this.LocalidadesMetroGrid.TabIndex = 0;
            // 
            // cmnLocalidad
            // 
            this.cmnLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnLocalidad.HeaderText = "Localidad";
            this.cmnLocalidad.Name = "cmnLocalidad";
            this.cmnLocalidad.ReadOnly = true;
            // 
            // cmnProvincia
            // 
            this.cmnProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnProvincia.HeaderText = "Provincia";
            this.cmnProvincia.Name = "cmnProvincia";
            this.cmnProvincia.ReadOnly = true;
            // 
            // SalirMetroButton
            // 
            this.SalirMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.exit_48px1;
            this.SalirMetroButton.Location = new System.Drawing.Point(398, 10);
            this.SalirMetroButton.Name = "SalirMetroButton";
            this.SalirMetroButton.Size = new System.Drawing.Size(52, 47);
            this.SalirMetroButton.TabIndex = 6;
            this.SalirMetroButton.UseSelectable = true;
            this.SalirMetroButton.Click += new System.EventHandler(this.SalirMetroButton_Click);
            // 
            // ActualizarMetroButton
            // 
            this.ActualizarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.actualizar_48px;
            this.ActualizarMetroButton.Location = new System.Drawing.Point(340, 10);
            this.ActualizarMetroButton.Name = "ActualizarMetroButton";
            this.ActualizarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.ActualizarMetroButton.TabIndex = 5;
            this.ActualizarMetroButton.UseSelectable = true;
            // 
            // BorrarMetroButton
            // 
            this.BorrarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.BorrarMetroButton.Location = new System.Drawing.Point(282, 10);
            this.BorrarMetroButton.Name = "BorrarMetroButton";
            this.BorrarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.BorrarMetroButton.TabIndex = 4;
            this.BorrarMetroButton.UseSelectable = true;
            this.BorrarMetroButton.Click += new System.EventHandler(this.BorrarMetroButton_Click);
            // 
            // EditarMetroButton
            // 
            this.EditarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.editar_48px;
            this.EditarMetroButton.Location = new System.Drawing.Point(224, 10);
            this.EditarMetroButton.Name = "EditarMetroButton";
            this.EditarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.EditarMetroButton.TabIndex = 3;
            this.EditarMetroButton.UseSelectable = true;
            this.EditarMetroButton.Click += new System.EventHandler(this.EditarMetroButton_Click);
            // 
            // NuevoMetroButton
            // 
            this.NuevoMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.nuevo_48px;
            this.NuevoMetroButton.Location = new System.Drawing.Point(166, 10);
            this.NuevoMetroButton.Name = "NuevoMetroButton";
            this.NuevoMetroButton.Size = new System.Drawing.Size(52, 47);
            this.NuevoMetroButton.TabIndex = 2;
            this.NuevoMetroButton.UseSelectable = true;
            this.NuevoMetroButton.Click += new System.EventHandler(this.NuevoMetroButton_Click);
            // 
            // LocalidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.ActualizarMetroButton);
            this.Controls.Add(this.BorrarMetroButton);
            this.Controls.Add(this.EditarMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.LocalidadesMetroGrid);
            this.Name = "LocalidadesForm";
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.PaisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid LocalidadesMetroGrid;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton EditarMetroButton;
        private MetroFramework.Controls.MetroButton BorrarMetroButton;
        private MetroFramework.Controls.MetroButton ActualizarMetroButton;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnProvincia;
    }
}