namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class BuscarLibroForm
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
            this.ProvinciaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.ProvinciasMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvinciaMetroLabel
            // 
            this.ProvinciaMetroLabel.AutoSize = true;
            this.ProvinciaMetroLabel.Location = new System.Drawing.Point(65, 102);
            this.ProvinciaMetroLabel.Name = "ProvinciaMetroLabel";
            this.ProvinciaMetroLabel.Size = new System.Drawing.Size(57, 19);
            this.ProvinciaMetroLabel.TabIndex = 2;
            this.ProvinciaMetroLabel.Text = "Autores:";
            // 
            // ProvinciasMetroComboBox
            // 
            this.ProvinciasMetroComboBox.FormattingEnabled = true;
            this.ProvinciasMetroComboBox.ItemHeight = 23;
            this.ProvinciasMetroComboBox.Location = new System.Drawing.Point(128, 92);
            this.ProvinciasMetroComboBox.Name = "ProvinciasMetroComboBox";
            this.ProvinciasMetroComboBox.Size = new System.Drawing.Size(150, 29);
            this.ProvinciasMetroComboBox.TabIndex = 3;
            this.ProvinciasMetroComboBox.UseSelectable = true;
            // 
            // OKMetroButton
            // 
            this.OKMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.ok_48px;
            this.OKMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OKMetroButton.Location = new System.Drawing.Point(50, 163);
            this.OKMetroButton.Name = "OKMetroButton";
            this.OKMetroButton.Size = new System.Drawing.Size(75, 59);
            this.OKMetroButton.TabIndex = 4;
            this.OKMetroButton.UseSelectable = true;
            this.OKMetroButton.Click += new System.EventHandler(this.OKMetroButton_Click);
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(203, 163);
            this.CancelMetroButton.Name = "CancelMetroButton";
            this.CancelMetroButton.Size = new System.Drawing.Size(75, 59);
            this.CancelMetroButton.TabIndex = 5;
            this.CancelMetroButton.UseSelectable = true;
            this.CancelMetroButton.Click += new System.EventHandler(this.CancelMetroButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BuscarLibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 263);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.ProvinciasMetroComboBox);
            this.Controls.Add(this.ProvinciaMetroLabel);
            this.Name = "BuscarLibroForm";
            this.Text = "Buscar Libro:";
            this.Load += new System.EventHandler(this.BuscarLibroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel ProvinciaMetroLabel;
        private MetroFramework.Controls.MetroComboBox ProvinciasMetroComboBox;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}