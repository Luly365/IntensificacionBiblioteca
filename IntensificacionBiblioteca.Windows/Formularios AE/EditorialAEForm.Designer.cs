namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class EditorialAEForm
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
            this.EditorialMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProvinciaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.PaisMetroComboBox = new MetroFramework.Controls.MetroComboBox();
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
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Editorial:";
            // 
            // EditorialMetroTextBox
            // 
            // 
            // 
            // 
            this.EditorialMetroTextBox.CustomButton.Image = null;
            this.EditorialMetroTextBox.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.EditorialMetroTextBox.CustomButton.Name = "";
            this.EditorialMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EditorialMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EditorialMetroTextBox.CustomButton.TabIndex = 1;
            this.EditorialMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EditorialMetroTextBox.CustomButton.UseSelectable = true;
            this.EditorialMetroTextBox.CustomButton.Visible = false;
            this.EditorialMetroTextBox.Lines = new string[0];
            this.EditorialMetroTextBox.Location = new System.Drawing.Point(126, 85);
            this.EditorialMetroTextBox.MaxLength = 50;
            this.EditorialMetroTextBox.Name = "EditorialMetroTextBox";
            this.EditorialMetroTextBox.PasswordChar = '\0';
            this.EditorialMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EditorialMetroTextBox.SelectedText = "";
            this.EditorialMetroTextBox.SelectionLength = 0;
            this.EditorialMetroTextBox.SelectionStart = 0;
            this.EditorialMetroTextBox.ShortcutsEnabled = true;
            this.EditorialMetroTextBox.Size = new System.Drawing.Size(152, 23);
            this.EditorialMetroTextBox.TabIndex = 1;
            this.EditorialMetroTextBox.UseSelectable = true;
            this.EditorialMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EditorialMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProvinciaMetroLabel
            // 
            this.ProvinciaMetroLabel.AutoSize = true;
            this.ProvinciaMetroLabel.Location = new System.Drawing.Point(50, 154);
            this.ProvinciaMetroLabel.Name = "ProvinciaMetroLabel";
            this.ProvinciaMetroLabel.Size = new System.Drawing.Size(34, 19);
            this.ProvinciaMetroLabel.TabIndex = 2;
            this.ProvinciaMetroLabel.Text = "Pais:";
            // 
            // PaisMetroComboBox
            // 
            this.PaisMetroComboBox.FormattingEnabled = true;
            this.PaisMetroComboBox.ItemHeight = 23;
            this.PaisMetroComboBox.Location = new System.Drawing.Point(126, 144);
            this.PaisMetroComboBox.Name = "PaisMetroComboBox";
            this.PaisMetroComboBox.Size = new System.Drawing.Size(150, 29);
            this.PaisMetroComboBox.TabIndex = 3;
            this.PaisMetroComboBox.UseSelectable = true;
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
            // EditorialAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 304);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.PaisMetroComboBox);
            this.Controls.Add(this.ProvinciaMetroLabel);
            this.Controls.Add(this.EditorialMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EditorialAEForm";
            this.Text = "Agregar Editorial";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox EditorialMetroTextBox;
        private MetroFramework.Controls.MetroLabel ProvinciaMetroLabel;
        private MetroFramework.Controls.MetroComboBox PaisMetroComboBox;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}