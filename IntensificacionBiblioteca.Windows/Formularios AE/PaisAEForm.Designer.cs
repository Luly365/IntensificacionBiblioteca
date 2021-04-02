namespace IntensificacionBiblioteca.Windows.Formularios_AE
{
    partial class PaisAEForm
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
            this.PaisMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PaisMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OKMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaisMetroTextBox
            // 
            // 
            // 
            // 
            this.PaisMetroTextBox.CustomButton.Image = null;
            this.PaisMetroTextBox.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.PaisMetroTextBox.CustomButton.Name = "";
            this.PaisMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PaisMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PaisMetroTextBox.CustomButton.TabIndex = 1;
            this.PaisMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PaisMetroTextBox.CustomButton.UseSelectable = true;
            this.PaisMetroTextBox.CustomButton.Visible = false;
            this.PaisMetroTextBox.Lines = new string[0];
            this.PaisMetroTextBox.Location = new System.Drawing.Point(105, 94);
            this.PaisMetroTextBox.MaxLength = 100;
            this.PaisMetroTextBox.Name = "PaisMetroTextBox";
            this.PaisMetroTextBox.PasswordChar = '\0';
            this.PaisMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PaisMetroTextBox.SelectedText = "";
            this.PaisMetroTextBox.SelectionLength = 0;
            this.PaisMetroTextBox.SelectionStart = 0;
            this.PaisMetroTextBox.ShortcutsEnabled = true;
            this.PaisMetroTextBox.Size = new System.Drawing.Size(171, 23);
            this.PaisMetroTextBox.TabIndex = 0;
            this.PaisMetroTextBox.UseSelectable = true;
            this.PaisMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PaisMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PaisMetroLabel
            // 
            this.PaisMetroLabel.AutoSize = true;
            this.PaisMetroLabel.Location = new System.Drawing.Point(23, 94);
            this.PaisMetroLabel.Name = "PaisMetroLabel";
            this.PaisMetroLabel.Size = new System.Drawing.Size(76, 19);
            this.PaisMetroLabel.TabIndex = 1;
            this.PaisMetroLabel.Text = "Nuevo Pais:";
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.cancel_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(216, 161);
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
            this.OKMetroButton.Location = new System.Drawing.Point(32, 161);
            this.OKMetroButton.Name = "OKMetroButton";
            this.OKMetroButton.Size = new System.Drawing.Size(60, 51);
            this.OKMetroButton.TabIndex = 2;
            this.OKMetroButton.UseSelectable = true;
            this.OKMetroButton.Click += new System.EventHandler(this.OkMetroButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PaisAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 259);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OKMetroButton);
            this.Controls.Add(this.PaisMetroLabel);
            this.Controls.Add(this.PaisMetroTextBox);
            this.Name = "PaisAEForm";
            this.Text = "Agregar Pais:";
            this.Load += new System.EventHandler(this.PaisAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PaisMetroTextBox;
        private MetroFramework.Controls.MetroLabel PaisMetroLabel;
        private MetroFramework.Controls.MetroButton OKMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}