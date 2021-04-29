namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class LibroAEForm
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
            this.components = new System.ComponentModel.Container();
            this.GeneroMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.EditorialMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.TituloMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProvinciaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.ISBNMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.TituloMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.ISBNMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EditorialMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.SubGeneroMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SubgeneroMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.EstadoLibroMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.EstadoMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.ObservacionesMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.FechaIncorporacionMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.FechaIncorporacionMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.DisponibleMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ObservacionestextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.StockMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.StockMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneroMetroComboBox
            // 
            this.GeneroMetroComboBox.FormattingEnabled = true;
            this.GeneroMetroComboBox.ItemHeight = 23;
            this.GeneroMetroComboBox.Location = new System.Drawing.Point(88, 193);
            this.GeneroMetroComboBox.Name = "GeneroMetroComboBox";
            this.GeneroMetroComboBox.Size = new System.Drawing.Size(234, 29);
            this.GeneroMetroComboBox.TabIndex = 9;
            this.GeneroMetroComboBox.UseSelectable = true;
            this.GeneroMetroComboBox.SelectedIndexChanged += new System.EventHandler(this.GeneroMetroComboBox_SelectedIndexChanged);
            // 
            // EditorialMetroComboBox
            // 
            this.EditorialMetroComboBox.FormattingEnabled = true;
            this.EditorialMetroComboBox.ItemHeight = 23;
            this.EditorialMetroComboBox.Location = new System.Drawing.Point(430, 129);
            this.EditorialMetroComboBox.Name = "EditorialMetroComboBox";
            this.EditorialMetroComboBox.Size = new System.Drawing.Size(270, 29);
            this.EditorialMetroComboBox.TabIndex = 8;
            this.EditorialMetroComboBox.UseSelectable = true;
            // 
            // TituloMetroTextBox
            // 
            // 
            // 
            // 
            this.TituloMetroTextBox.CustomButton.Image = null;
            this.TituloMetroTextBox.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.TituloMetroTextBox.CustomButton.Name = "";
            this.TituloMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TituloMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TituloMetroTextBox.CustomButton.TabIndex = 1;
            this.TituloMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TituloMetroTextBox.CustomButton.UseSelectable = true;
            this.TituloMetroTextBox.CustomButton.Visible = false;
            this.TituloMetroTextBox.Lines = new string[0];
            this.TituloMetroTextBox.Location = new System.Drawing.Point(88, 90);
            this.TituloMetroTextBox.MaxLength = 250;
            this.TituloMetroTextBox.Name = "TituloMetroTextBox";
            this.TituloMetroTextBox.PasswordChar = '\0';
            this.TituloMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TituloMetroTextBox.SelectedText = "";
            this.TituloMetroTextBox.SelectionLength = 0;
            this.TituloMetroTextBox.SelectionStart = 0;
            this.TituloMetroTextBox.ShortcutsEnabled = true;
            this.TituloMetroTextBox.Size = new System.Drawing.Size(612, 23);
            this.TituloMetroTextBox.TabIndex = 4;
            this.TituloMetroTextBox.UseSelectable = true;
            this.TituloMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TituloMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProvinciaMetroLabel
            // 
            this.ProvinciaMetroLabel.AutoSize = true;
            this.ProvinciaMetroLabel.Location = new System.Drawing.Point(29, 203);
            this.ProvinciaMetroLabel.Name = "ProvinciaMetroLabel";
            this.ProvinciaMetroLabel.Size = new System.Drawing.Size(55, 19);
            this.ProvinciaMetroLabel.TabIndex = 3;
            this.ProvinciaMetroLabel.Text = "Genero:";
            // 
            // ISBNMetroLabel
            // 
            this.ISBNMetroLabel.AutoSize = true;
            this.ISBNMetroLabel.Location = new System.Drawing.Point(29, 135);
            this.ISBNMetroLabel.Name = "ISBNMetroLabel";
            this.ISBNMetroLabel.Size = new System.Drawing.Size(40, 19);
            this.ISBNMetroLabel.TabIndex = 2;
            this.ISBNMetroLabel.Text = "ISBN:";
            // 
            // TituloMetroLabel
            // 
            this.TituloMetroLabel.AutoSize = true;
            this.TituloMetroLabel.Location = new System.Drawing.Point(29, 90);
            this.TituloMetroLabel.Name = "TituloMetroLabel";
            this.TituloMetroLabel.Size = new System.Drawing.Size(44, 19);
            this.TituloMetroLabel.TabIndex = 0;
            this.TituloMetroLabel.Text = "Titulo:";
            // 
            // OKMetroButton
            // 
            this.OKMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.ok_48px;
            this.OKMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OKMetroButton.Location = new System.Drawing.Point(158, 517);
            this.OKMetroButton.Name = "OKMetroButton";
            this.OKMetroButton.Size = new System.Drawing.Size(75, 52);
            this.OKMetroButton.TabIndex = 11;
            this.OKMetroButton.UseSelectable = true;
            this.OKMetroButton.Click += new System.EventHandler(this.OKMetroButton_Click);
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(513, 517);
            this.CancelMetroButton.Name = "CancelMetroButton";
            this.CancelMetroButton.Size = new System.Drawing.Size(75, 52);
            this.CancelMetroButton.TabIndex = 13;
            this.CancelMetroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelMetroButton.UseSelectable = true;
            this.CancelMetroButton.Click += new System.EventHandler(this.CancelMetroButton_Click);
            // 
            // ISBNMetroTextBox
            // 
            // 
            // 
            // 
            this.ISBNMetroTextBox.CustomButton.Image = null;
            this.ISBNMetroTextBox.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.ISBNMetroTextBox.CustomButton.Name = "";
            this.ISBNMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ISBNMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ISBNMetroTextBox.CustomButton.TabIndex = 1;
            this.ISBNMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ISBNMetroTextBox.CustomButton.UseSelectable = true;
            this.ISBNMetroTextBox.CustomButton.Visible = false;
            this.ISBNMetroTextBox.Lines = new string[0];
            this.ISBNMetroTextBox.Location = new System.Drawing.Point(88, 135);
            this.ISBNMetroTextBox.MaxLength = 13;
            this.ISBNMetroTextBox.Name = "ISBNMetroTextBox";
            this.ISBNMetroTextBox.PasswordChar = '\0';
            this.ISBNMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ISBNMetroTextBox.SelectedText = "";
            this.ISBNMetroTextBox.SelectionLength = 0;
            this.ISBNMetroTextBox.SelectionStart = 0;
            this.ISBNMetroTextBox.ShortcutsEnabled = true;
            this.ISBNMetroTextBox.Size = new System.Drawing.Size(234, 23);
            this.ISBNMetroTextBox.TabIndex = 14;
            this.ISBNMetroTextBox.UseSelectable = true;
            this.ISBNMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ISBNMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EditorialMetroLabel
            // 
            this.EditorialMetroLabel.AutoSize = true;
            this.EditorialMetroLabel.Location = new System.Drawing.Point(349, 135);
            this.EditorialMetroLabel.Name = "EditorialMetroLabel";
            this.EditorialMetroLabel.Size = new System.Drawing.Size(60, 19);
            this.EditorialMetroLabel.TabIndex = 15;
            this.EditorialMetroLabel.Text = "Editorial:";
            // 
            // SubGeneroMetroComboBox
            // 
            this.SubGeneroMetroComboBox.FormattingEnabled = true;
            this.SubGeneroMetroComboBox.ItemHeight = 23;
            this.SubGeneroMetroComboBox.Location = new System.Drawing.Point(430, 193);
            this.SubGeneroMetroComboBox.Name = "SubGeneroMetroComboBox";
            this.SubGeneroMetroComboBox.Size = new System.Drawing.Size(270, 29);
            this.SubGeneroMetroComboBox.TabIndex = 17;
            this.SubGeneroMetroComboBox.UseSelectable = true;
            // 
            // SubgeneroMetroLabel
            // 
            this.SubgeneroMetroLabel.AutoSize = true;
            this.SubgeneroMetroLabel.Location = new System.Drawing.Point(349, 203);
            this.SubgeneroMetroLabel.Name = "SubgeneroMetroLabel";
            this.SubgeneroMetroLabel.Size = new System.Drawing.Size(81, 19);
            this.SubgeneroMetroLabel.TabIndex = 16;
            this.SubgeneroMetroLabel.Text = "Sub Genero:";
            // 
            // EstadoLibroMetroComboBox
            // 
            this.EstadoLibroMetroComboBox.FormattingEnabled = true;
            this.EstadoLibroMetroComboBox.ItemHeight = 23;
            this.EstadoLibroMetroComboBox.Location = new System.Drawing.Point(142, 260);
            this.EstadoLibroMetroComboBox.Name = "EstadoLibroMetroComboBox";
            this.EstadoLibroMetroComboBox.Size = new System.Drawing.Size(180, 29);
            this.EstadoLibroMetroComboBox.TabIndex = 19;
            this.EstadoLibroMetroComboBox.UseSelectable = true;
            // 
            // EstadoMetroLabel
            // 
            this.EstadoMetroLabel.AutoSize = true;
            this.EstadoMetroLabel.Location = new System.Drawing.Point(29, 260);
            this.EstadoMetroLabel.Name = "EstadoMetroLabel";
            this.EstadoMetroLabel.Size = new System.Drawing.Size(107, 19);
            this.EstadoMetroLabel.TabIndex = 18;
            this.EstadoMetroLabel.Text = "Estado del Libro:";
            // 
            // ObservacionesMetroLabel
            // 
            this.ObservacionesMetroLabel.AutoSize = true;
            this.ObservacionesMetroLabel.Location = new System.Drawing.Point(23, 396);
            this.ObservacionesMetroLabel.Name = "ObservacionesMetroLabel";
            this.ObservacionesMetroLabel.Size = new System.Drawing.Size(98, 19);
            this.ObservacionesMetroLabel.TabIndex = 20;
            this.ObservacionesMetroLabel.Text = "Observaciones:";
            // 
            // FechaIncorporacionMetroDateTime
            // 
            this.FechaIncorporacionMetroDateTime.Location = new System.Drawing.Point(486, 260);
            this.FechaIncorporacionMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.FechaIncorporacionMetroDateTime.Name = "FechaIncorporacionMetroDateTime";
            this.FechaIncorporacionMetroDateTime.Size = new System.Drawing.Size(214, 29);
            this.FechaIncorporacionMetroDateTime.TabIndex = 21;
            // 
            // FechaIncorporacionMetroLabel
            // 
            this.FechaIncorporacionMetroLabel.AutoSize = true;
            this.FechaIncorporacionMetroLabel.Location = new System.Drawing.Point(349, 260);
            this.FechaIncorporacionMetroLabel.Name = "FechaIncorporacionMetroLabel";
            this.FechaIncorporacionMetroLabel.Size = new System.Drawing.Size(131, 19);
            this.FechaIncorporacionMetroLabel.TabIndex = 22;
            this.FechaIncorporacionMetroLabel.Text = "Fecha Incorporacion:";
            // 
            // DisponibleMetroCheckBox
            // 
            this.DisponibleMetroCheckBox.AutoSize = true;
            this.DisponibleMetroCheckBox.Location = new System.Drawing.Point(430, 338);
            this.DisponibleMetroCheckBox.Name = "DisponibleMetroCheckBox";
            this.DisponibleMetroCheckBox.Size = new System.Drawing.Size(79, 15);
            this.DisponibleMetroCheckBox.TabIndex = 24;
            this.DisponibleMetroCheckBox.Text = "Disponible";
            this.DisponibleMetroCheckBox.UseSelectable = true;
            // 
            // ObservacionestextBox
            // 
            this.ObservacionestextBox.Location = new System.Drawing.Point(127, 396);
            this.ObservacionestextBox.Multiline = true;
            this.ObservacionestextBox.Name = "ObservacionestextBox";
            this.ObservacionestextBox.Size = new System.Drawing.Size(469, 56);
            this.ObservacionestextBox.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StockMetroLabel
            // 
            this.StockMetroLabel.AutoSize = true;
            this.StockMetroLabel.Location = new System.Drawing.Point(29, 338);
            this.StockMetroLabel.Name = "StockMetroLabel";
            this.StockMetroLabel.Size = new System.Drawing.Size(104, 19);
            this.StockMetroLabel.TabIndex = 26;
            this.StockMetroLabel.Text = "Cantidad Libros:";
            // 
            // StockMetroTextBox
            // 
            // 
            // 
            // 
            this.StockMetroTextBox.CustomButton.Image = null;
            this.StockMetroTextBox.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.StockMetroTextBox.CustomButton.Name = "";
            this.StockMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StockMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StockMetroTextBox.CustomButton.TabIndex = 1;
            this.StockMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StockMetroTextBox.CustomButton.UseSelectable = true;
            this.StockMetroTextBox.CustomButton.Visible = false;
            this.StockMetroTextBox.Lines = new string[0];
            this.StockMetroTextBox.Location = new System.Drawing.Point(140, 333);
            this.StockMetroTextBox.MaxLength = 32767;
            this.StockMetroTextBox.Name = "StockMetroTextBox";
            this.StockMetroTextBox.PasswordChar = '\0';
            this.StockMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StockMetroTextBox.SelectedText = "";
            this.StockMetroTextBox.SelectionLength = 0;
            this.StockMetroTextBox.SelectionStart = 0;
            this.StockMetroTextBox.ShortcutsEnabled = true;
            this.StockMetroTextBox.Size = new System.Drawing.Size(168, 23);
            this.StockMetroTextBox.TabIndex = 27;
            this.StockMetroTextBox.UseSelectable = true;
            this.StockMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LibroAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 592);
            this.ControlBox = false;
            this.Controls.Add(this.StockMetroTextBox);
            this.Controls.Add(this.StockMetroLabel);
            this.Controls.Add(this.ObservacionestextBox);
            this.Controls.Add(this.DisponibleMetroCheckBox);
            this.Controls.Add(this.FechaIncorporacionMetroLabel);
            this.Controls.Add(this.FechaIncorporacionMetroDateTime);
            this.Controls.Add(this.ObservacionesMetroLabel);
            this.Controls.Add(this.EstadoLibroMetroComboBox);
            this.Controls.Add(this.EstadoMetroLabel);
            this.Controls.Add(this.SubGeneroMetroComboBox);
            this.Controls.Add(this.SubgeneroMetroLabel);
            this.Controls.Add(this.GeneroMetroComboBox);
            this.Controls.Add(this.ProvinciaMetroLabel);
            this.Controls.Add(this.EditorialMetroLabel);
            this.Controls.Add(this.EditorialMetroComboBox);
            this.Controls.Add(this.ISBNMetroTextBox);
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.TituloMetroTextBox);
            this.Controls.Add(this.ISBNMetroLabel);
            this.Controls.Add(this.TituloMetroLabel);
            this.MinimumSize = new System.Drawing.Size(748, 484);
            this.Name = "LibroAEForm";
            this.Text = "Agregar Libro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox GeneroMetroComboBox;
        private MetroFramework.Controls.MetroComboBox EditorialMetroComboBox;
        private MetroFramework.Controls.MetroTextBox TituloMetroTextBox;
        private MetroFramework.Controls.MetroLabel ProvinciaMetroLabel;
        private MetroFramework.Controls.MetroLabel ISBNMetroLabel;
        private MetroFramework.Controls.MetroLabel TituloMetroLabel;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private MetroFramework.Controls.MetroTextBox ISBNMetroTextBox;
        private MetroFramework.Controls.MetroLabel EditorialMetroLabel;
        private MetroFramework.Controls.MetroComboBox SubGeneroMetroComboBox;
        private MetroFramework.Controls.MetroLabel SubgeneroMetroLabel;
        private MetroFramework.Controls.MetroComboBox EstadoLibroMetroComboBox;
        private MetroFramework.Controls.MetroLabel EstadoMetroLabel;
        private MetroFramework.Controls.MetroLabel ObservacionesMetroLabel;
        private MetroFramework.Controls.MetroDateTime FechaIncorporacionMetroDateTime;
        private MetroFramework.Controls.MetroLabel FechaIncorporacionMetroLabel;
        private MetroFramework.Controls.MetroCheckBox DisponibleMetroCheckBox;
        private System.Windows.Forms.TextBox ObservacionestextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTextBox StockMetroTextBox;
        private MetroFramework.Controls.MetroLabel StockMetroLabel;
    }
}