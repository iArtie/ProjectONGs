namespace ONGs.Formularios
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asociacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOCIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRABAJADORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROYECTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBPROYECTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asociacionesToolStripMenuItem,
            this.sOCIOSToolStripMenuItem,
            this.tRABAJADORESToolStripMenuItem,
            this.pROYECTOSToolStripMenuItem,
            this.sUBPROYECTOSToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asociacionesToolStripMenuItem
            // 
            this.asociacionesToolStripMenuItem.Name = "asociacionesToolStripMenuItem";
            this.asociacionesToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.asociacionesToolStripMenuItem.Text = "ASOCIACIONES";
            this.asociacionesToolStripMenuItem.Click += new System.EventHandler(this.asociacionesToolStripMenuItem_Click);
            // 
            // sOCIOSToolStripMenuItem
            // 
            this.sOCIOSToolStripMenuItem.Name = "sOCIOSToolStripMenuItem";
            this.sOCIOSToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sOCIOSToolStripMenuItem.Text = "SOCIOS";
            this.sOCIOSToolStripMenuItem.Click += new System.EventHandler(this.sOCIOSToolStripMenuItem_Click);
            // 
            // tRABAJADORESToolStripMenuItem
            // 
            this.tRABAJADORESToolStripMenuItem.Name = "tRABAJADORESToolStripMenuItem";
            this.tRABAJADORESToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.tRABAJADORESToolStripMenuItem.Text = "TRABAJADORES";
            this.tRABAJADORESToolStripMenuItem.Click += new System.EventHandler(this.tRABAJADORESToolStripMenuItem_Click);
            // 
            // pROYECTOSToolStripMenuItem
            // 
            this.pROYECTOSToolStripMenuItem.Name = "pROYECTOSToolStripMenuItem";
            this.pROYECTOSToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.pROYECTOSToolStripMenuItem.Text = "PROYECTOS";
            this.pROYECTOSToolStripMenuItem.Click += new System.EventHandler(this.pROYECTOSToolStripMenuItem_Click);
            // 
            // sUBPROYECTOSToolStripMenuItem
            // 
            this.sUBPROYECTOSToolStripMenuItem.Name = "sUBPROYECTOSToolStripMenuItem";
            this.sUBPROYECTOSToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.sUBPROYECTOSToolStripMenuItem.Text = "SUBPROYECTOS";
            this.sUBPROYECTOSToolStripMenuItem.Click += new System.EventHandler(this.sUBPROYECTOSToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.reporteToolStripMenuItem.Text = "REPORTE";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1290, 702);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asociacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOCIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRABAJADORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROYECTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBPROYECTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
    }
}
