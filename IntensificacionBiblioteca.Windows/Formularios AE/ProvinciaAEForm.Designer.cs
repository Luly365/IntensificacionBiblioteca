namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class ProvinciaAEForm
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
            this.ProvinciaMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProvinciaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvinciaMetroTextBox
            // 
            // 
            // 
            // 
            this.ProvinciaMetroTextBox.CustomButton.Image = null;
            this.ProvinciaMetroTextBox.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.ProvinciaMetroTextBox.CustomButton.Name = "";
            this.ProvinciaMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProvinciaMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProvinciaMetroTextBox.CustomButton.TabIndex = 1;
            this.ProvinciaMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProvinciaMetroTextBox.CustomButton.UseSelectable = true;
            this.ProvinciaMetroTextBox.CustomButton.Visible = false;
            this.ProvinciaMetroTextBox.Lines = new string[0];
            this.ProvinciaMetroTextBox.Location = new System.Drawing.Point(135, 94);
            this.ProvinciaMetroTextBox.MaxLength = 100;
            this.ProvinciaMetroTextBox.Name = "ProvinciaMetroTextBox";
            this.ProvinciaMetroTextBox.PasswordChar = '\0';
            this.ProvinciaMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProvinciaMetroTextBox.SelectedText = "";
            this.ProvinciaMetroTextBox.SelectionLength = 0;
            this.ProvinciaMetroTextBox.SelectionStart = 0;
            this.ProvinciaMetroTextBox.ShortcutsEnabled = true;
            this.ProvinciaMetroTextBox.Size = new System.Drawing.Size(155, 23);
            this.ProvinciaMetroTextBox.TabIndex = 0;
            this.ProvinciaMetroTextBox.UseSelectable = true;
            this.ProvinciaMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProvinciaMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProvinciaMetroLabel
            // 
            this.ProvinciaMetroLabel.AutoSize = true;
            this.ProvinciaMetroLabel.Location = new System.Drawing.Point(23, 94);
            this.ProvinciaMetroLabel.Name = "ProvinciaMetroLabel";
            this.ProvinciaMetroLabel.Size = new System.Drawing.Size(106, 19);
            this.ProvinciaMetroLabel.TabIndex = 1;
            this.ProvinciaMetroLabel.Text = "Nueva Provincia:";
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(230, 161);
            this.CancelMetroButton.Name = "CancelMetroButton";
            this.CancelMetroButton.Size = new System.Drawing.Size(60, 51);
            this.CancelMetroButton.TabIndex = 3;
            this.CancelMetroButton.UseSelectable = true;
            this.CancelMetroButton.Click += new System.EventHandler(this.CancelMetroButton_Click);
            // 
            // OKMetroButton
            // 
            this.OKMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.ok_48px;
            this.OKMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OKMetroButton.Location = new System.Drawing.Point(23, 161);
            this.OKMetroButton.Name = "OKMetroButton";
            this.OKMetroButton.Size = new System.Drawing.Size(60, 51);
            this.OKMetroButton.TabIndex = 2;
            this.OKMetroButton.UseSelectable = true;
            this.OKMetroButton.Click += new System.EventHandler(this.OKMetroButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProvinciaAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 259);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.ProvinciaMetroLabel);
            this.Controls.Add(this.ProvinciaMetroTextBox);
            this.Name = "ProvinciaAEForm";
            this.Text = "Agregar Provincia:";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ProvinciaMetroTextBox;
        private MetroFramework.Controls.MetroLabel ProvinciaMetroLabel;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}