namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class TipoDeDocAEForm
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
            this.TipoDeDocMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.TipoDeDocMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoDeDocMetroLabel
            // 
            this.TipoDeDocMetroLabel.AutoSize = true;
            this.TipoDeDocMetroLabel.Location = new System.Drawing.Point(23, 98);
            this.TipoDeDocMetroLabel.Name = "TipoDeDocMetroLabel";
            this.TipoDeDocMetroLabel.Size = new System.Drawing.Size(127, 19);
            this.TipoDeDocMetroLabel.TabIndex = 0;
            this.TipoDeDocMetroLabel.Text = "Nuevo Tipo De Doc:";
            // 
            // TipoDeDocMetroTextBox
            // 
            // 
            // 
            // 
            this.TipoDeDocMetroTextBox.CustomButton.Image = null;
            this.TipoDeDocMetroTextBox.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.TipoDeDocMetroTextBox.CustomButton.Name = "";
            this.TipoDeDocMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TipoDeDocMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TipoDeDocMetroTextBox.CustomButton.TabIndex = 1;
            this.TipoDeDocMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TipoDeDocMetroTextBox.CustomButton.UseSelectable = true;
            this.TipoDeDocMetroTextBox.CustomButton.Visible = false;
            this.TipoDeDocMetroTextBox.Lines = new string[0];
            this.TipoDeDocMetroTextBox.Location = new System.Drawing.Point(156, 98);
            this.TipoDeDocMetroTextBox.MaxLength = 30;
            this.TipoDeDocMetroTextBox.Name = "TipoDeDocMetroTextBox";
            this.TipoDeDocMetroTextBox.PasswordChar = '\0';
            this.TipoDeDocMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TipoDeDocMetroTextBox.SelectedText = "";
            this.TipoDeDocMetroTextBox.SelectionLength = 0;
            this.TipoDeDocMetroTextBox.SelectionStart = 0;
            this.TipoDeDocMetroTextBox.ShortcutsEnabled = true;
            this.TipoDeDocMetroTextBox.Size = new System.Drawing.Size(166, 23);
            this.TipoDeDocMetroTextBox.TabIndex = 1;
            this.TipoDeDocMetroTextBox.UseSelectable = true;
            this.TipoDeDocMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TipoDeDocMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // TipoDeDocAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 245);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.TipoDeDocMetroTextBox);
            this.Controls.Add(this.TipoDeDocMetroLabel);
            this.MaximumSize = new System.Drawing.Size(350, 245);
            this.MinimumSize = new System.Drawing.Size(350, 245);
            this.Name = "TipoDeDocAEForm";
            this.Text = "Agregar Tipos De Doc:";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel TipoDeDocMetroLabel;
        private MetroFramework.Controls.MetroTextBox TipoDeDocMetroTextBox;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}