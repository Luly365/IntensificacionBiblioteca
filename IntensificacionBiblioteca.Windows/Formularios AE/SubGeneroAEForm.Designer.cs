namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class SubGeneroAEForm
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
            this.SubGeneroMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.SubGeneroMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.GeneroMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.GenerosMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubGeneroMetroLabel
            // 
            this.SubGeneroMetroLabel.AutoSize = true;
            this.SubGeneroMetroLabel.Location = new System.Drawing.Point(50, 89);
            this.SubGeneroMetroLabel.Name = "SubGeneroMetroLabel";
            this.SubGeneroMetroLabel.Size = new System.Drawing.Size(77, 19);
            this.SubGeneroMetroLabel.TabIndex = 0;
            this.SubGeneroMetroLabel.Text = "SubGenero:";
            // 
            // SubGeneroMetroTextBox
            // 
            // 
            // 
            // 
            this.SubGeneroMetroTextBox.CustomButton.Image = null;
            this.SubGeneroMetroTextBox.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.SubGeneroMetroTextBox.CustomButton.Name = "";
            this.SubGeneroMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SubGeneroMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SubGeneroMetroTextBox.CustomButton.TabIndex = 1;
            this.SubGeneroMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SubGeneroMetroTextBox.CustomButton.UseSelectable = true;
            this.SubGeneroMetroTextBox.CustomButton.Visible = false;
            this.SubGeneroMetroTextBox.Lines = new string[0];
            this.SubGeneroMetroTextBox.Location = new System.Drawing.Point(126, 85);
            this.SubGeneroMetroTextBox.MaxLength = 32767;
            this.SubGeneroMetroTextBox.Name = "SubGeneroMetroTextBox";
            this.SubGeneroMetroTextBox.PasswordChar = '\0';
            this.SubGeneroMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SubGeneroMetroTextBox.SelectedText = "";
            this.SubGeneroMetroTextBox.SelectionLength = 0;
            this.SubGeneroMetroTextBox.SelectionStart = 0;
            this.SubGeneroMetroTextBox.ShortcutsEnabled = true;
            this.SubGeneroMetroTextBox.Size = new System.Drawing.Size(152, 23);
            this.SubGeneroMetroTextBox.TabIndex = 1;
            this.SubGeneroMetroTextBox.UseSelectable = true;
            this.SubGeneroMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SubGeneroMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GeneroMetroLabel
            // 
            this.GeneroMetroLabel.AutoSize = true;
            this.GeneroMetroLabel.Location = new System.Drawing.Point(50, 154);
            this.GeneroMetroLabel.Name = "GeneroMetroLabel";
            this.GeneroMetroLabel.Size = new System.Drawing.Size(60, 19);
            this.GeneroMetroLabel.TabIndex = 2;
            this.GeneroMetroLabel.Text = "Generos:";
            // 
            // GenerosMetroComboBox
            // 
            this.GenerosMetroComboBox.FormattingEnabled = true;
            this.GenerosMetroComboBox.ItemHeight = 23;
            this.GenerosMetroComboBox.Location = new System.Drawing.Point(126, 144);
            this.GenerosMetroComboBox.Name = "GenerosMetroComboBox";
            this.GenerosMetroComboBox.Size = new System.Drawing.Size(150, 29);
            this.GenerosMetroComboBox.TabIndex = 3;
            this.GenerosMetroComboBox.UseSelectable = true;
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
            // SubGeneroAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 304);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.GenerosMetroComboBox);
            this.Controls.Add(this.GeneroMetroLabel);
            this.Controls.Add(this.SubGeneroMetroTextBox);
            this.Controls.Add(this.SubGeneroMetroLabel);
            this.Name = "SubGeneroAEForm";
            this.Text = "Agregar SubGenero";
            this.Load += new System.EventHandler(this.SubGeneroAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel SubGeneroMetroLabel;
        private MetroFramework.Controls.MetroTextBox SubGeneroMetroTextBox;
        private MetroFramework.Controls.MetroLabel GeneroMetroLabel;
        private MetroFramework.Controls.MetroComboBox GenerosMetroComboBox;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}