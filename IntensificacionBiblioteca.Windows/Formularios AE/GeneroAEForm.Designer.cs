namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class GeneroAEForm
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
            this.GeneroMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PaisMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneroMetroTextBox
            // 
            // 
            // 
            // 
            this.GeneroMetroTextBox.CustomButton.Image = null;
            this.GeneroMetroTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.GeneroMetroTextBox.CustomButton.Name = "";
            this.GeneroMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.GeneroMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GeneroMetroTextBox.CustomButton.TabIndex = 1;
            this.GeneroMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GeneroMetroTextBox.CustomButton.UseSelectable = true;
            this.GeneroMetroTextBox.CustomButton.Visible = false;
            this.GeneroMetroTextBox.Lines = new string[0];
            this.GeneroMetroTextBox.Location = new System.Drawing.Point(125, 90);
            this.GeneroMetroTextBox.MaxLength = 100;
            this.GeneroMetroTextBox.Name = "GeneroMetroTextBox";
            this.GeneroMetroTextBox.PasswordChar = '\0';
            this.GeneroMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GeneroMetroTextBox.SelectedText = "";
            this.GeneroMetroTextBox.SelectionLength = 0;
            this.GeneroMetroTextBox.SelectionStart = 0;
            this.GeneroMetroTextBox.ShortcutsEnabled = true;
            this.GeneroMetroTextBox.Size = new System.Drawing.Size(173, 23);
            this.GeneroMetroTextBox.TabIndex = 0;
            this.GeneroMetroTextBox.UseSelectable = true;
            this.GeneroMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GeneroMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PaisMetroLabel
            // 
            this.PaisMetroLabel.AutoSize = true;
            this.PaisMetroLabel.Location = new System.Drawing.Point(23, 94);
            this.PaisMetroLabel.Name = "PaisMetroLabel";
            this.PaisMetroLabel.Size = new System.Drawing.Size(97, 19);
            this.PaisMetroLabel.TabIndex = 1;
            this.PaisMetroLabel.Text = "Nuevo Genero:";
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(230, 161);
            this.CancelMetroButton.Name = "CancelMetroButton";
            this.CancelMetroButton.Size = new System.Drawing.Size(68, 51);
            this.CancelMetroButton.TabIndex = 3;
            this.CancelMetroButton.UseSelectable = true;
            this.CancelMetroButton.Click += new System.EventHandler(this.CancelMetroButton_Click);
            // 
            // OKMetroButton
            // 
            this.OKMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.ok_48px;
            this.OKMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OKMetroButton.Location = new System.Drawing.Point(32, 161);
            this.OKMetroButton.Name = "OKMetroButton";
            this.OKMetroButton.Size = new System.Drawing.Size(68, 51);
            this.OKMetroButton.TabIndex = 2;
            this.OKMetroButton.UseSelectable = true;
            this.OKMetroButton.Click += new System.EventHandler(this.OKMetroButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GeneroAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 259);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.PaisMetroLabel);
            this.Controls.Add(this.GeneroMetroTextBox);
            this.Name = "GeneroAEForm";
            this.Text = "Agregar Genero:";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox GeneroMetroTextBox;
        private MetroFramework.Controls.MetroLabel PaisMetroLabel;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}