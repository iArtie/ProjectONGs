namespace ONGs.Formularios
{
    partial class FrmReport
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtbPrint = new System.Windows.Forms.DataGridView();
            this.cmbPrint = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtbPrint
            // 
            this.dtbPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbPrint.Location = new System.Drawing.Point(12, 83);
            this.dtbPrint.Name = "dtbPrint";
            this.dtbPrint.Size = new System.Drawing.Size(925, 198);
            this.dtbPrint.TabIndex = 1;
            // 
            // cmbPrint
            // 
            this.cmbPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrint.FormattingEnabled = true;
            this.cmbPrint.Items.AddRange(new object[] {
            "Lista de Asociaciones",
            "Lista de Socios",
            "Lista de Trabajadores Asalariados",
            "Lista de Trabajadores Voluntarios",
            "Lista de Proyectos",
            "Lista de SubProyectos"});
            this.cmbPrint.Location = new System.Drawing.Point(364, 11);
            this.cmbPrint.Name = "cmbPrint";
            this.cmbPrint.Size = new System.Drawing.Size(191, 21);
            this.cmbPrint.TabIndex = 2;
            this.cmbPrint.SelectedIndexChanged += new System.EventHandler(this.cmbPrint_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Que desea ver?";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(431, 45);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(0, 24);
            this.lblList.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ONGs.Properties.Resources.report;
            this.pictureBox1.Location = new System.Drawing.Point(81, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReport
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPrint);
            this.Controls.Add(this.dtbPrint);
            this.Controls.Add(this.button1);
            this.Name = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtbPrint;
        private System.Windows.Forms.ComboBox cmbPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
