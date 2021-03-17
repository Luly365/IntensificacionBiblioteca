namespace IntensificacionBiblioteca.Windows
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrestamosMetroTile = new MetroFramework.Controls.MetroTile();
            this.SociosMetroTile = new MetroFramework.Controls.MetroTile();
            this.LibroMetroTile = new MetroFramework.Controls.MetroTile();
            this.SalirMetroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // PrestamosMetroTile
            // 
            this.PrestamosMetroTile.ActiveControl = null;
            this.PrestamosMetroTile.BackColor = System.Drawing.Color.Silver;
            this.PrestamosMetroTile.Location = new System.Drawing.Point(23, 217);
            this.PrestamosMetroTile.Name = "PrestamosMetroTile";
            this.PrestamosMetroTile.Size = new System.Drawing.Size(243, 76);
            this.PrestamosMetroTile.TabIndex = 3;
            this.PrestamosMetroTile.Text = "Prestamos";
            this.PrestamosMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PrestamosMetroTile.TileImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.prestamos_48px;
            this.PrestamosMetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrestamosMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.PrestamosMetroTile.UseCustomBackColor = true;
            this.PrestamosMetroTile.UseSelectable = true;
            this.PrestamosMetroTile.UseTileImage = true;
            // 
            // SociosMetroTile
            // 
            this.SociosMetroTile.ActiveControl = null;
            this.SociosMetroTile.BackColor = System.Drawing.Color.Silver;
            this.SociosMetroTile.Location = new System.Drawing.Point(153, 87);
            this.SociosMetroTile.Name = "SociosMetroTile";
            this.SociosMetroTile.Size = new System.Drawing.Size(113, 109);
            this.SociosMetroTile.TabIndex = 2;
            this.SociosMetroTile.Text = "Socios";
            this.SociosMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SociosMetroTile.TileImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.socios_48px;
            this.SociosMetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SociosMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SociosMetroTile.UseCustomBackColor = true;
            this.SociosMetroTile.UseSelectable = true;
            this.SociosMetroTile.UseTileImage = true;
            this.SociosMetroTile.Click += new System.EventHandler(this.SociosMetroTile_Click);
            // 
            // LibroMetroTile
            // 
            this.LibroMetroTile.ActiveControl = null;
            this.LibroMetroTile.BackColor = System.Drawing.Color.Silver;
            this.LibroMetroTile.Location = new System.Drawing.Point(23, 87);
            this.LibroMetroTile.Name = "LibroMetroTile";
            this.LibroMetroTile.Size = new System.Drawing.Size(113, 109);
            this.LibroMetroTile.TabIndex = 1;
            this.LibroMetroTile.Text = "Libros";
            this.LibroMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LibroMetroTile.TileImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.Libros_48px;
            this.LibroMetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LibroMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.LibroMetroTile.UseCustomBackColor = true;
            this.LibroMetroTile.UseSelectable = true;
            this.LibroMetroTile.UseTileImage = true;
            this.LibroMetroTile.Click += new System.EventHandler(this.LibroMetroTile_Click);
            // 
            // SalirMetroTile
            // 
            this.SalirMetroTile.ActiveControl = null;
            this.SalirMetroTile.BackColor = System.Drawing.Color.Silver;
            this.SalirMetroTile.Location = new System.Drawing.Point(355, 285);
            this.SalirMetroTile.Name = "SalirMetroTile";
            this.SalirMetroTile.Size = new System.Drawing.Size(86, 95);
            this.SalirMetroTile.TabIndex = 0;
            this.SalirMetroTile.Text = "Salir";
            this.SalirMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalirMetroTile.TileImage = global::IntensificacionBiblioteca.Windows.Properties.Resources.exit_48px;
            this.SalirMetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalirMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SalirMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SalirMetroTile.UseCustomBackColor = true;
            this.SalirMetroTile.UseSelectable = true;
            this.SalirMetroTile.UseTileImage = true;
            this.SalirMetroTile.Click += new System.EventHandler(this.SalirMetroTile_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PrestamosMetroTile);
            this.Controls.Add(this.SociosMetroTile);
            this.Controls.Add(this.LibroMetroTile);
            this.Controls.Add(this.SalirMetroTile);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile SalirMetroTile;
        private MetroFramework.Controls.MetroTile LibroMetroTile;
        private MetroFramework.Controls.MetroTile SociosMetroTile;
        private MetroFramework.Controls.MetroTile PrestamosMetroTile;
    }
}

