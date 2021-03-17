namespace IntensificacionBiblioteca.Windows
{
    partial class GenerosForm
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
            this.GeneroMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.ActualizarMetroButton = new MetroFramework.Controls.MetroButton();
            this.BorrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.EditarMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            this.cmnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneroMetroGrid
            // 
            this.GeneroMetroGrid.AllowUserToAddRows = false;
            this.GeneroMetroGrid.AllowUserToDeleteRows = false;
            this.GeneroMetroGrid.AllowUserToResizeRows = false;
            this.GeneroMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GeneroMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneroMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GeneroMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GeneroMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GeneroMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneroMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnGenero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GeneroMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.GeneroMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneroMetroGrid.EnableHeadersVisualStyles = false;
            this.GeneroMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GeneroMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GeneroMetroGrid.Location = new System.Drawing.Point(20, 60);
            this.GeneroMetroGrid.Name = "GeneroMetroGrid";
            this.GeneroMetroGrid.ReadOnly = true;
            this.GeneroMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GeneroMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GeneroMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GeneroMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GeneroMetroGrid.Size = new System.Drawing.Size(442, 370);
            this.GeneroMetroGrid.TabIndex = 0;
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
            // cmnGenero
            // 
            this.cmnGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnGenero.HeaderText = "Genero";
            this.cmnGenero.Name = "cmnGenero";
            this.cmnGenero.ReadOnly = true;
            // 
            // GenerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.ActualizarMetroButton);
            this.Controls.Add(this.BorrarMetroButton);
            this.Controls.Add(this.EditarMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.GeneroMetroGrid);
            this.Name = "GenerosForm";
            this.Text = "Generos";
            this.Load += new System.EventHandler(this.PaisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneroMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GeneroMetroGrid;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton EditarMetroButton;
        private MetroFramework.Controls.MetroButton BorrarMetroButton;
        private MetroFramework.Controls.MetroButton ActualizarMetroButton;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnGenero;
    }
}