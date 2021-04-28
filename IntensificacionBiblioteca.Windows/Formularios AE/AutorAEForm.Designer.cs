namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class AutorAEForm
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
            this.AutorMetroTextBox = new MetroFramework.Controls.MetroTextBox();
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
            this.EstadoMetroLabel.Size = new System.Drawing.Size(88, 19);
            this.EstadoMetroLabel.TabIndex = 0;
            this.EstadoMetroLabel.Text = "Nuevo Autor:";
            // 
            // AutorMetroTextBox
            // 
            // 
            // 
            // 
            this.AutorMetroTextBox.CustomButton.Image = null;
            this.AutorMetroTextBox.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.AutorMetroTextBox.CustomButton.Name = "";
            this.AutorMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AutorMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutorMetroTextBox.CustomButton.TabIndex = 1;
            this.AutorMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutorMetroTextBox.CustomButton.UseSelectable = true;
            this.AutorMetroTextBox.CustomButton.Visible = false;
            this.AutorMetroTextBox.Lines = new string[0];
            this.AutorMetroTextBox.Location = new System.Drawing.Point(119, 98);
            this.AutorMetroTextBox.MaxLength = 100;
            this.AutorMetroTextBox.Name = "AutorMetroTextBox";
            this.AutorMetroTextBox.PasswordChar = '\0';
            this.AutorMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutorMetroTextBox.SelectedText = "";
            this.AutorMetroTextBox.SelectionLength = 0;
            this.AutorMetroTextBox.SelectionStart = 0;
            this.AutorMetroTextBox.ShortcutsEnabled = true;
            this.AutorMetroTextBox.Size = new System.Drawing.Size(149, 23);
            this.AutorMetroTextBox.TabIndex = 1;
            this.AutorMetroTextBox.UseSelectable = true;
            this.AutorMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutorMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.CancelMetroButton.Location = new System.Drawing.Point(193, 167);
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
            // AutorAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 259);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.AutorMetroTextBox);
            this.Controls.Add(this.EstadoMetroLabel);
            this.Name = "AutorAEForm";
            this.Text = "Agregar Autor:";
            this.Load += new System.EventHandler(this.AutorAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel EstadoMetroLabel;
        private MetroFramework.Controls.MetroTextBox AutorMetroTextBox;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}