namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class LocalidadAEForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LocalidadMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProvinciaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.ProvinciasMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Localidad:";
            // 
            // LocalidadMetroTextBox
            // 
            // 
            // 
            // 
            this.LocalidadMetroTextBox.CustomButton.Image = null;
            this.LocalidadMetroTextBox.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.LocalidadMetroTextBox.CustomButton.Name = "";
            this.LocalidadMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LocalidadMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocalidadMetroTextBox.CustomButton.TabIndex = 1;
            this.LocalidadMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocalidadMetroTextBox.CustomButton.UseSelectable = true;
            this.LocalidadMetroTextBox.CustomButton.Visible = false;
            this.LocalidadMetroTextBox.Lines = new string[0];
            this.LocalidadMetroTextBox.Location = new System.Drawing.Point(126, 85);
            this.LocalidadMetroTextBox.MaxLength = 100;
            this.LocalidadMetroTextBox.Name = "LocalidadMetroTextBox";
            this.LocalidadMetroTextBox.PasswordChar = '\0';
            this.LocalidadMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LocalidadMetroTextBox.SelectedText = "";
            this.LocalidadMetroTextBox.SelectionLength = 0;
            this.LocalidadMetroTextBox.SelectionStart = 0;
            this.LocalidadMetroTextBox.ShortcutsEnabled = true;
            this.LocalidadMetroTextBox.Size = new System.Drawing.Size(152, 23);
            this.LocalidadMetroTextBox.TabIndex = 1;
            this.LocalidadMetroTextBox.UseSelectable = true;
            this.LocalidadMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocalidadMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProvinciaMetroLabel
            // 
            this.ProvinciaMetroLabel.AutoSize = true;
            this.ProvinciaMetroLabel.Location = new System.Drawing.Point(50, 154);
            this.ProvinciaMetroLabel.Name = "ProvinciaMetroLabel";
            this.ProvinciaMetroLabel.Size = new System.Drawing.Size(70, 19);
            this.ProvinciaMetroLabel.TabIndex = 2;
            this.ProvinciaMetroLabel.Text = "Provincias:";
            // 
            // ProvinciasMetroComboBox
            // 
            this.ProvinciasMetroComboBox.FormattingEnabled = true;
            this.ProvinciasMetroComboBox.ItemHeight = 23;
            this.ProvinciasMetroComboBox.Location = new System.Drawing.Point(126, 144);
            this.ProvinciasMetroComboBox.Name = "ProvinciasMetroComboBox";
            this.ProvinciasMetroComboBox.Size = new System.Drawing.Size(150, 29);
            this.ProvinciasMetroComboBox.TabIndex = 3;
            this.ProvinciasMetroComboBox.UseSelectable = true;
            // 
            // OKMetroButton
            // 
            this.OKMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.ok_48px;
            this.OKMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OKMetroButton.Location = new System.Drawing.Point(50, 210);
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
            this.CancelMetroButton.Location = new System.Drawing.Point(203, 210);
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
            // LocalidadAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 304);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.ProvinciasMetroComboBox);
            this.Controls.Add(this.ProvinciaMetroLabel);
            this.Controls.Add(this.LocalidadMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LocalidadAEForm";
            this.Text = "Agregar Localidad";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox LocalidadMetroTextBox;
        private MetroFramework.Controls.MetroLabel ProvinciaMetroLabel;
        private MetroFramework.Controls.MetroComboBox ProvinciasMetroComboBox;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}