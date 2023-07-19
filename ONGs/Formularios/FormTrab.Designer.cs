namespace ONGs.Formularios
{
    partial class FormTrab
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtbTrab = new System.Windows.Forms.DataGridView();
            this.lbles = new System.Windows.Forms.Label();
            this.txtESSA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblim = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.lblsal = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtbVon = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblh = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnTerm = new System.Windows.Forms.Button();
            this.btnUptV = new System.Windows.Forms.Button();
            this.btnDeleteV = new System.Windows.Forms.Button();
            this.lbllol = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtbTrab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbVon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "denominacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "denominacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "provincia";
            this.dataGridViewTextBoxColumn4.HeaderText = "provincia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn5.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "declarada_utilidad_publica";
            this.dataGridViewCheckBoxColumn1.HeaderText = "declarada_utilidad_publica";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dtbTrab
            // 
            this.dtbTrab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbTrab.Location = new System.Drawing.Point(439, 57);
            this.dtbTrab.Name = "dtbTrab";
            this.dtbTrab.Size = new System.Drawing.Size(770, 215);
            this.dtbTrab.TabIndex = 0;
            this.dtbTrab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbTrab_CellClick);
            // 
            // lbles
            // 
            this.lbles.AutoSize = true;
            this.lbles.Location = new System.Drawing.Point(31, 325);
            this.lbles.Name = "lbles";
            this.lbles.Size = new System.Drawing.Size(60, 13);
            this.lbles.TabIndex = 40;
            this.lbles.Text = "ESSALUD:";
            // 
            // txtESSA
            // 
            this.txtESSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESSA.Location = new System.Drawing.Point(119, 318);
            this.txtESSA.Multiline = true;
            this.txtESSA.Name = "txtESSA";
            this.txtESSA.Size = new System.Drawing.Size(223, 24);
            this.txtESSA.TabIndex = 39;
            this.txtESSA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtESSA_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(36, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Profesion:";
            // 
            // txtProf
            // 
            this.txtProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProf.Location = new System.Drawing.Point(120, 272);
            this.txtProf.Multiline = true;
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(223, 24);
            this.txtProf.TabIndex = 37;
            this.txtProf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProf_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(119, 160);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 24);
            this.txtNombre.TabIndex = 34;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(35, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(34, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(119, 219);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(223, 24);
            this.txtEdad.TabIndex = 31;
            this.txtEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdad_KeyDown);
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(118, 112);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(223, 24);
            this.txtDNI.TabIndex = 30;
            this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNI_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "DNI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(35, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "asalariado",
            "voluntario"});
            this.cmbTipo.Location = new System.Drawing.Point(119, 63);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(222, 21);
            this.cmbTipo.TabIndex = 42;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblim
            // 
            this.lblim.AutoSize = true;
            this.lblim.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblim.Location = new System.Drawing.Point(30, 372);
            this.lblim.Name = "lblim";
            this.lblim.Size = new System.Drawing.Size(53, 13);
            this.lblim.TabIndex = 44;
            this.lblim.Text = "Impuesto:";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(118, 365);
            this.txtImpuesto.Multiline = true;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(223, 24);
            this.txtImpuesto.TabIndex = 43;
            this.txtImpuesto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImpuesto_KeyDown);
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblsal.Location = new System.Drawing.Point(30, 420);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(42, 13);
            this.lblsal.TabIndex = 46;
            this.lblsal.Text = "Salario:";
            this.lblsal.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(118, 413);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(223, 24);
            this.txtSalario.TabIndex = 45;
            this.txtSalario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalario_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 49;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 48;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtbVon
            // 
            this.dtbVon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbVon.Location = new System.Drawing.Point(439, 330);
            this.dtbVon.Name = "dtbVon";
            this.dtbVon.Size = new System.Drawing.Size(770, 215);
            this.dtbVon.TabIndex = 50;
            this.dtbVon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbVon_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(756, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Asalariados:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(756, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "Voluntarios:";
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblh.Location = new System.Drawing.Point(22, 325);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(90, 13);
            this.lblh.TabIndex = 54;
            this.lblh.Text = "Horas dedicadas:";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(119, 318);
            this.txtHoras.Multiline = true;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(223, 24);
            this.txtHoras.TabIndex = 53;
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoras_TextChanged);
            this.txtHoras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoras_KeyDown);
            // 
            // btnTerm
            // 
            this.btnTerm.Location = new System.Drawing.Point(293, 473);
            this.btnTerm.Name = "btnTerm";
            this.btnTerm.Size = new System.Drawing.Size(80, 23);
            this.btnTerm.TabIndex = 55;
            this.btnTerm.Text = "Terminar";
            this.btnTerm.UseVisualStyleBackColor = true;
            this.btnTerm.Click += new System.EventHandler(this.btnTerm_Click);
            // 
            // btnUptV
            // 
            this.btnUptV.Location = new System.Drawing.Point(98, 536);
            this.btnUptV.Name = "btnUptV";
            this.btnUptV.Size = new System.Drawing.Size(80, 25);
            this.btnUptV.TabIndex = 56;
            this.btnUptV.Text = "Modificar";
            this.btnUptV.UseVisualStyleBackColor = true;
            this.btnUptV.Click += new System.EventHandler(this.btnUptV_Click);
            // 
            // btnDeleteV
            // 
            this.btnDeleteV.Location = new System.Drawing.Point(195, 536);
            this.btnDeleteV.Name = "btnDeleteV";
            this.btnDeleteV.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteV.TabIndex = 57;
            this.btnDeleteV.Text = "Eliminar";
            this.btnDeleteV.UseVisualStyleBackColor = true;
            this.btnDeleteV.Click += new System.EventHandler(this.btnDeleteV_Click);
            // 
            // lbllol
            // 
            this.lbllol.AutoSize = true;
            this.lbllol.Location = new System.Drawing.Point(376, 30);
            this.lbllol.Name = "lbllol";
            this.lbllol.Size = new System.Drawing.Size(0, 13);
            this.lbllol.TabIndex = 58;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 25);
            this.button3.TabIndex = 59;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 625);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ONGs.Properties.Resources.pngwing_com__2_;
            this.pictureBox1.Location = new System.Drawing.Point(352, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormTrab
            // 
            this.ClientSize = new System.Drawing.Size(1232, 589);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbllol);
            this.Controls.Add(this.btnDeleteV);
            this.Controls.Add(this.btnUptV);
            this.Controls.Add(this.btnTerm);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtbVon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblim);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbles);
            this.Controls.Add(this.txtESSA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtbTrab);
            this.Controls.Add(this.panel1);
            this.Name = "FormTrab";
            this.Load += new System.EventHandler(this.FormTrab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtbTrab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbVon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dtbTrab;
        private System.Windows.Forms.Label lbles;
        private System.Windows.Forms.TextBox txtESSA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblim;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtbVon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnTerm;
        private System.Windows.Forms.Button btnUptV;
        private System.Windows.Forms.Button btnDeleteV;
        public System.Windows.Forms.Label lbllol;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
