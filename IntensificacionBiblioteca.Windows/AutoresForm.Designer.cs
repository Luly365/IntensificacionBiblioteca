namespace IntensificacionBiblioteca.Windows
{
    partial class AutoresForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AutoresMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnAutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.ActualizarMetroButton = new MetroFramework.Controls.MetroButton();
            this.BorrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.EditarMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.AutoresMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoresMetroGrid
            // 
            this.AutoresMetroGrid.AllowUserToAddRows = false;
            this.AutoresMetroGrid.AllowUserToDeleteRows = false;
            this.AutoresMetroGrid.AllowUserToResizeRows = false;
            this.AutoresMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AutoresMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutoresMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AutoresMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AutoresMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AutoresMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoresMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnAutores});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AutoresMetroGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.AutoresMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoresMetroGrid.EnableHeadersVisualStyles = false;
            this.AutoresMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AutoresMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AutoresMetroGrid.Location = new System.Drawing.Point(20, 60);
            this.AutoresMetroGrid.Name = "AutoresMetroGrid";
            this.AutoresMetroGrid.ReadOnly = true;
            this.AutoresMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AutoresMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.AutoresMetroGrid.RowHeadersVisible = false;
            this.AutoresMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AutoresMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AutoresMetroGrid.Size = new System.Drawing.Size(398, 370);
            this.AutoresMetroGrid.TabIndex = 0;
            // 
            // cmnAutores
            // 
            this.cmnAutores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnAutores.HeaderText = "Autores";
            this.cmnAutores.Name = "cmnAutores";
            this.cmnAutores.ReadOnly = true;
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
            // AutoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.ActualizarMetroButton);
            this.Controls.Add(this.BorrarMetroButton);
            this.Controls.Add(this.EditarMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.AutoresMetroGrid);
            this.Name = "AutoresForm";
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.AutoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoresMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid AutoresMetroGrid;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton EditarMetroButton;
        private MetroFramework.Controls.MetroButton BorrarMetroButton;
        private MetroFramework.Controls.MetroButton ActualizarMetroButton;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnAutores;
    }
}