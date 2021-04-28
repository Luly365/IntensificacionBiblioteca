namespace IntensificacionBiblioteca.Windows
{
    partial class LibrosPrestadosForm
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
            this.LibroPrestamosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.DevolverMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.LibroPrestamosMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LibroPrestamosMetroGrid
            // 
            this.LibroPrestamosMetroGrid.AllowUserToAddRows = false;
            this.LibroPrestamosMetroGrid.AllowUserToDeleteRows = false;
            this.LibroPrestamosMetroGrid.AllowUserToResizeRows = false;
            this.LibroPrestamosMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LibroPrestamosMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibroPrestamosMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LibroPrestamosMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibroPrestamosMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LibroPrestamosMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibroPrestamosMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTitulo,
            this.cmnISBN,
            this.cmnEstado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LibroPrestamosMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.LibroPrestamosMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibroPrestamosMetroGrid.EnableHeadersVisualStyles = false;
            this.LibroPrestamosMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LibroPrestamosMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LibroPrestamosMetroGrid.Location = new System.Drawing.Point(20, 60);
            this.LibroPrestamosMetroGrid.Name = "LibroPrestamosMetroGrid";
            this.LibroPrestamosMetroGrid.ReadOnly = true;
            this.LibroPrestamosMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LibroPrestamosMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LibroPrestamosMetroGrid.RowHeadersVisible = false;
            this.LibroPrestamosMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LibroPrestamosMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibroPrestamosMetroGrid.Size = new System.Drawing.Size(623, 370);
            this.LibroPrestamosMetroGrid.TabIndex = 0;
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
            // cmnEstado
            // 
            this.cmnEstado.HeaderText = "Estado";
            this.cmnEstado.Name = "cmnEstado";
            this.cmnEstado.ReadOnly = true;
            // 
            // SalirMetroButton
            // 
            this.SalirMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.exit_48px1;
            this.SalirMetroButton.Location = new System.Drawing.Point(588, 10);
            this.SalirMetroButton.Name = "SalirMetroButton";
            this.SalirMetroButton.Size = new System.Drawing.Size(52, 47);
            this.SalirMetroButton.TabIndex = 6;
            this.SalirMetroButton.UseSelectable = true;
            this.SalirMetroButton.Click += new System.EventHandler(this.SalirMetroButton_Click);
            // 
            // DevolverMetroButton
            // 
            this.DevolverMetroButton.Location = new System.Drawing.Point(478, 10);
            this.DevolverMetroButton.Name = "DevolverMetroButton";
            this.DevolverMetroButton.Size = new System.Drawing.Size(104, 47);
            this.DevolverMetroButton.TabIndex = 7;
            this.DevolverMetroButton.Text = "Devolver";
            this.DevolverMetroButton.UseSelectable = true;
            this.DevolverMetroButton.Click += new System.EventHandler(this.DevolverMetroButton_Click);
            // 
            // LibrosPrestadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.ControlBox = false;
            this.Controls.Add(this.DevolverMetroButton);
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.LibroPrestamosMetroGrid);
            this.Name = "LibrosPrestadosForm";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.LibrosPrestadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibroPrestamosMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid LibroPrestamosMetroGrid;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private MetroFramework.Controls.MetroButton DevolverMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEstado;
    }
}