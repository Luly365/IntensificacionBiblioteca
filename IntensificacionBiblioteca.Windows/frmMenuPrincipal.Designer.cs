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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPPaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPProvinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPTiposDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPGenerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPSubGenerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPEstadoDeLosLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.PrestamosMetroTile.Click += new System.EventHandler(this.PrestamosMetroTile_Click);
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
            this.SociosMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MPPaisesToolStripMenuItem,
            this.MPProvinciasToolStripMenuItem,
            this.MPLocalidadesToolStripMenuItem,
            this.MPTiposDeDocumentosToolStripMenuItem,
            this.MPGenerosToolStripMenuItem,
            this.MPSubGenerosToolStripMenuItem,
            this.MPAutoresToolStripMenuItem,
            this.MPEstadoDeLosLibrosToolStripMenuItem,
            this.editorialesToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // MPPaisesToolStripMenuItem
            // 
            this.MPPaisesToolStripMenuItem.Name = "MPPaisesToolStripMenuItem";
            this.MPPaisesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPPaisesToolStripMenuItem.Text = "Paises";
            this.MPPaisesToolStripMenuItem.Click += new System.EventHandler(this.MPPaisesToolStripMenuItem_Click);
            // 
            // MPProvinciasToolStripMenuItem
            // 
            this.MPProvinciasToolStripMenuItem.Name = "MPProvinciasToolStripMenuItem";
            this.MPProvinciasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPProvinciasToolStripMenuItem.Text = "Provincias";
            this.MPProvinciasToolStripMenuItem.Click += new System.EventHandler(this.MPProvinciasToolStripMenuItem_Click);
            // 
            // MPLocalidadesToolStripMenuItem
            // 
            this.MPLocalidadesToolStripMenuItem.Name = "MPLocalidadesToolStripMenuItem";
            this.MPLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPLocalidadesToolStripMenuItem.Text = "Localidades";
            this.MPLocalidadesToolStripMenuItem.Click += new System.EventHandler(this.MPLocalidadesToolStripMenuItem_Click);
            // 
            // MPTiposDeDocumentosToolStripMenuItem
            // 
            this.MPTiposDeDocumentosToolStripMenuItem.Name = "MPTiposDeDocumentosToolStripMenuItem";
            this.MPTiposDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPTiposDeDocumentosToolStripMenuItem.Text = "Tipos De Documentos";
            this.MPTiposDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.MPTiposDeDocumentosToolStripMenuItem_Click);
            // 
            // MPGenerosToolStripMenuItem
            // 
            this.MPGenerosToolStripMenuItem.Name = "MPGenerosToolStripMenuItem";
            this.MPGenerosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPGenerosToolStripMenuItem.Text = "Generos";
            this.MPGenerosToolStripMenuItem.Click += new System.EventHandler(this.MPGenerosToolStripMenuItem_Click);
            // 
            // MPSubGenerosToolStripMenuItem
            // 
            this.MPSubGenerosToolStripMenuItem.Name = "MPSubGenerosToolStripMenuItem";
            this.MPSubGenerosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPSubGenerosToolStripMenuItem.Text = "SubGeneros";
            this.MPSubGenerosToolStripMenuItem.Click += new System.EventHandler(this.MPSubGenerosToolStripMenuItem_Click);
            // 
            // MPAutoresToolStripMenuItem
            // 
            this.MPAutoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresLibrosToolStripMenuItem});
            this.MPAutoresToolStripMenuItem.Name = "MPAutoresToolStripMenuItem";
            this.MPAutoresToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPAutoresToolStripMenuItem.Text = "Autores";
            this.MPAutoresToolStripMenuItem.Click += new System.EventHandler(this.MPAutoresToolStripMenuItem_Click);
            // 
            // autoresLibrosToolStripMenuItem
            // 
            this.autoresLibrosToolStripMenuItem.Name = "autoresLibrosToolStripMenuItem";
            this.autoresLibrosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.autoresLibrosToolStripMenuItem.Text = "Autores Libros";
            this.autoresLibrosToolStripMenuItem.Click += new System.EventHandler(this.autoresLibrosToolStripMenuItem_Click);
            // 
            // MPEstadoDeLosLibrosToolStripMenuItem
            // 
            this.MPEstadoDeLosLibrosToolStripMenuItem.Name = "MPEstadoDeLosLibrosToolStripMenuItem";
            this.MPEstadoDeLosLibrosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MPEstadoDeLosLibrosToolStripMenuItem.Text = "Estado de los Libros";
            this.MPEstadoDeLosLibrosToolStripMenuItem.Click += new System.EventHandler(this.MPEstadoDeLosLibrosToolStripMenuItem_Click);
            // 
            // editorialesToolStripMenuItem
            // 
            this.editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            this.editorialesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editorialesToolStripMenuItem.Text = "Editoriales";
            this.editorialesToolStripMenuItem.Click += new System.EventHandler(this.editorialesToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 412);
            this.ControlBox = false;
            this.Controls.Add(this.PrestamosMetroTile);
            this.Controls.Add(this.SociosMetroTile);
            this.Controls.Add(this.LibroMetroTile);
            this.Controls.Add(this.SalirMetroTile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile SalirMetroTile;
        private MetroFramework.Controls.MetroTile LibroMetroTile;
        private MetroFramework.Controls.MetroTile SociosMetroTile;
        private MetroFramework.Controls.MetroTile PrestamosMetroTile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPPaisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPProvinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPLocalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPTiposDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPGenerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPSubGenerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPEstadoDeLosLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresLibrosToolStripMenuItem;
    }
}

