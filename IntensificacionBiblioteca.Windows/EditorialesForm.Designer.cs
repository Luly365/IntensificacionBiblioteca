namespace IntensificacionBiblioteca.Windows
{
    partial class EditorialesForm
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
            this.EditorialesMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarMetroButton = new MetroFramework.Controls.MetroButton();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.ActualizarMetroButton = new MetroFramework.Controls.MetroButton();
            this.BorrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.EditarMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.EditorialesMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EditorialesMetroGrid
            // 
            this.EditorialesMetroGrid.AllowUserToAddRows = false;
            this.EditorialesMetroGrid.AllowUserToDeleteRows = false;
            this.EditorialesMetroGrid.AllowUserToResizeRows = false;
            this.EditorialesMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditorialesMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditorialesMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EditorialesMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EditorialesMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EditorialesMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditorialesMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnEditorial,
            this.cmnPais});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditorialesMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditorialesMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorialesMetroGrid.EnableHeadersVisualStyles = false;
            this.EditorialesMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EditorialesMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditorialesMetroGrid.Location = new System.Drawing.Point(20, 60);
            this.EditorialesMetroGrid.Name = "EditorialesMetroGrid";
            this.EditorialesMetroGrid.ReadOnly = true;
            this.EditorialesMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EditorialesMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EditorialesMetroGrid.RowHeadersVisible = false;
            this.EditorialesMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorialesMetroGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EditorialesMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EditorialesMetroGrid.Size = new System.Drawing.Size(501, 370);
            this.EditorialesMetroGrid.TabIndex = 0;
            // 
            // cmnEditorial
            // 
            this.cmnEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnEditorial.HeaderText = "Editorial";
            this.cmnEditorial.Name = "cmnEditorial";
            this.cmnEditorial.ReadOnly = true;
            // 
            // cmnPais
            // 
            this.cmnPais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnPais.HeaderText = "Pais";
            this.cmnPais.Name = "cmnPais";
            this.cmnPais.ReadOnly = true;
            // 
            // BuscarMetroButton
            // 
            this.BuscarMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.Buscar_48px;
            this.BuscarMetroButton.Location = new System.Drawing.Point(398, 10);
            this.BuscarMetroButton.Name = "BuscarMetroButton";
            this.BuscarMetroButton.Size = new System.Drawing.Size(52, 47);
            this.BuscarMetroButton.TabIndex = 9;
            this.BuscarMetroButton.UseSelectable = true;
            this.BuscarMetroButton.Click += new System.EventHandler(this.BuscarMetroButton_Click);
            // 
            // SalirMetroButton
            // 
            this.SalirMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.exit_48px1;
            this.SalirMetroButton.Location = new System.Drawing.Point(456, 10);
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
            this.ActualizarMetroButton.Click += new System.EventHandler(this.ActualizarMetroButton_Click);
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
            // EditorialesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BuscarMetroButton);
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.ActualizarMetroButton);
            this.Controls.Add(this.BorrarMetroButton);
            this.Controls.Add(this.EditarMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.EditorialesMetroGrid);
            this.Name = "EditorialesForm";
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.EditorialesForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.EditorialesMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid EditorialesMetroGrid;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton EditarMetroButton;
        private MetroFramework.Controls.MetroButton BorrarMetroButton;
        private MetroFramework.Controls.MetroButton ActualizarMetroButton;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPais;
        private MetroFramework.Controls.MetroButton BuscarMetroButton;
    }
}