namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class EstadoAEForm
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
            this.EstadoMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.EstadoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadoMetroLabel
            // 
            this.EstadoMetroLabel.AutoSize = true;
            this.EstadoMetroLabel.Location = new System.Drawing.Point(23, 98);
            this.EstadoMetroLabel.Name = "EstadoMetroLabel";
            this.EstadoMetroLabel.Size = new System.Drawing.Size(93, 19);
            this.EstadoMetroLabel.TabIndex = 0;
            this.EstadoMetroLabel.Text = "Nuevo Estado:";
            // 
            // EstadoMetroTextBox
            // 
            // 
            // 
            // 
            this.EstadoMetroTextBox.CustomButton.Image = null;
            this.EstadoMetroTextBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.EstadoMetroTextBox.CustomButton.Name = "";
            this.EstadoMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EstadoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EstadoMetroTextBox.CustomButton.TabIndex = 1;
            this.EstadoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EstadoMetroTextBox.CustomButton.UseSelectable = true;
            this.EstadoMetroTextBox.CustomButton.Visible = false;
            this.EstadoMetroTextBox.Lines = new string[0];
            this.EstadoMetroTextBox.Location = new System.Drawing.Point(123, 98);
            this.EstadoMetroTextBox.MaxLength = 100;
            this.EstadoMetroTextBox.Name = "EstadoMetroTextBox";
            this.EstadoMetroTextBox.PasswordChar = '\0';
            this.EstadoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EstadoMetroTextBox.SelectedText = "";
            this.EstadoMetroTextBox.SelectionLength = 0;
            this.EstadoMetroTextBox.SelectionStart = 0;
            this.EstadoMetroTextBox.ShortcutsEnabled = true;
            this.EstadoMetroTextBox.Size = new System.Drawing.Size(199, 23);
            this.EstadoMetroTextBox.TabIndex = 1;
            this.EstadoMetroTextBox.UseSelectable = true;
            this.EstadoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EstadoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OKMetroButton
            // 
            this.OKMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.ok_48px;
            this.OKMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OKMetroButton.Location = new System.Drawing.Point(23, 167);
            this.OKMetroButton.Name = "OKMetroButton";
            this.OKMetroButton.Size = new System.Drawing.Size(75, 55);
            this.OKMetroButton.TabIndex = 2;
            this.OKMetroButton.UseSelectable = true;
            this.OKMetroButton.Click += new System.EventHandler(this.OKMetroButton_Click);
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(247, 167);
            this.CancelMetroButton.Name = "CancelMetroButton";
            this.CancelMetroButton.Size = new System.Drawing.Size(75, 55);
            this.CancelMetroButton.TabIndex = 3;
            this.CancelMetroButton.UseSelectable = true;
            this.CancelMetroButton.Click += new System.EventHandler(this.CancelMetroButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstadoAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 245);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.EstadoMetroTextBox);
            this.Controls.Add(this.EstadoMetroLabel);
            this.MaximumSize = new System.Drawing.Size(350, 245);
            this.MinimumSize = new System.Drawing.Size(350, 245);
            this.Name = "EstadoAEForm";
            this.Text = "Agregar Estados de Libros:";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel EstadoMetroLabel;
        private MetroFramework.Controls.MetroTextBox EstadoMetroTextBox;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}