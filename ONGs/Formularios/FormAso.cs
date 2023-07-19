using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace ONGs.Formularios
{
    public partial class FormAso : Form
    {
        Conexion con = new Conexion("sa","123456");
        public FormAso()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAso_Load(object sender, EventArgs e)
        {
            con.ListarAsociaciones(dtbAso);
            btnTerm.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtDenom.Text == "" || txtDir.Text == "" || txtProv.Text == "" || txtTipo.Text == "")
            {

                MessageBox.Show("No se pudo agregar debido a que hay casiilas en blanco");
            }
            else
            {
                con.NuevaAsociacion(dtbAso, txtDenom.Text, txtDir.Text, txtProv.Text, txtTipo.Text, 1);
                MessageBox.Show("Asociacion agregada correctamente");
                con.ListarAsociaciones(dtbAso);
                ClearT();
            }
            
        }
        public string valcan;
        private void dtbAso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtbAso.Rows[e.RowIndex];
            valcan = Convert.ToString(fila.Cells[0].Value);
            valcan = valcan.Trim();
            lblID.Text = valcan;
            txtDenom.Text = Convert.ToString(fila.Cells[1].Value).Trim();
            txtDir.Text = Convert.ToString(fila.Cells[2].Value).Trim();
            txtProv.Text = Convert.ToString(fila.Cells[3].Value).Trim();
            txtTipo.Text = Convert.ToString(fila.Cells[4].Value).Trim();

            txtDenom.Enabled = false;
            txtDir.Enabled = false;
            txtProv.Enabled = false;
            txtTipo.Enabled = false;
        }

        public void ClearT()
        {
            txtDenom.Text = "";
            txtDir.Text = "";
            txtProv.Text = "";
            txtTipo.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (valcan == null)
            {
                MessageBox.Show("No tiene ninguna asociacion seleccionada");
            }
            else
            {
                btnAdd.Enabled = false;
                btnTerm.Visible = true;
                txtDenom.Enabled = true;
                txtDir.Enabled = true;
                txtProv.Enabled = true;
                txtTipo.Enabled = true;
            }
            

           
        }

        private void btnTerm_Click(object sender, EventArgs e)
        {
            btnTerm.Visible = false;
            if (txtDenom.Text == "" || txtDir.Text == "" || txtProv.Text == "" || txtTipo.Text == "")
            {

                MessageBox.Show("No se pudo modificar debido a que hay casiilas en blanco");
            }
            else
            {
                con.ModificarAsociacion(dtbAso, valcan, txtDenom.Text, txtDir.Text, txtProv.Text, txtTipo.Text, 1);
                MessageBox.Show("Asociacion actualizada correctamente");
                con.ListarAsociaciones(dtbAso);
                ClearT();
                valcan = null;
                lblID.Text = valcan;
                btnAdd.Enabled =  true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(valcan == null)
            {
                MessageBox.Show("No tiene ninguna asociacion seleccionada");
            }
            else 
            {
                con.EliminarAsociacion(dtbAso,valcan);
                MessageBox.Show("Asociacion eliminada correctamente");
                con.ListarAsociaciones(dtbAso);
                valcan = null;
                lblID.Text = valcan;
                ClearT();
                btnTerm.Visible = false;
                txtDenom.Enabled = true;
                txtDir.Enabled = true;
                txtProv.Enabled = true;
                txtTipo.Enabled = true;
            }
        }

        private void txtDenom_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) &&
                    !(e.KeyCode == Keys.OemPeriod) &&
                    !(e.KeyCode == Keys.Oemcomma) &&
                    !(e.KeyCode == Keys.Space) &&
                    !(e.KeyCode == Keys.Back) &&
                    !(e.KeyCode == Keys.Delete) &&
                    !(e.KeyCode == Keys.ControlKey) &&
                    !(e.KeyCode == Keys.Control) &&
                    !(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
                    !(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
                    !(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
                    !(e.KeyCode == Keys.Home) &&
                    !(e.KeyCode == Keys.End) &&
                    !(e.KeyCode == Keys.Left) &&
                    !(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtProv_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) &&
                   !(e.KeyCode == Keys.OemPeriod) &&
                   !(e.KeyCode == Keys.Oemcomma) &&
                   !(e.KeyCode == Keys.Space) &&
                   !(e.KeyCode == Keys.Back) &&
                   !(e.KeyCode == Keys.Delete) &&
                   !(e.KeyCode == Keys.ControlKey) &&
                   !(e.KeyCode == Keys.Control) &&
                   !(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
                   !(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
                   !(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
                   !(e.KeyCode == Keys.Home) &&
                   !(e.KeyCode == Keys.End) &&
                   !(e.KeyCode == Keys.Left) &&
                   !(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) &&
                   !(e.KeyCode == Keys.OemPeriod) &&
                   !(e.KeyCode == Keys.Oemcomma) &&
                   !(e.KeyCode == Keys.Space) &&
                   !(e.KeyCode == Keys.Back) &&
                   !(e.KeyCode == Keys.Delete) &&
                   !(e.KeyCode == Keys.ControlKey) &&
                   !(e.KeyCode == Keys.Control) &&
                   !(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
                   !(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
                   !(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
                   !(e.KeyCode == Keys.Home) &&
                   !(e.KeyCode == Keys.End) &&
                   !(e.KeyCode == Keys.Left) &&
                   !(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valcan = null;
            lblID.Text = valcan;
            ClearT();
            btnTerm.Visible = true;
            txtDenom.Enabled = true;
            txtDir.Enabled = true;
            txtProv.Enabled = true;
            txtTipo.Enabled = true;
            btnTerm.Visible = false;
            btnAdd.Enabled = true;
        }
    }
}
