using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ONGs.Formularios
{
    public partial class FormTrab : Form
    {
        Conexion con = new Conexion("sa", "123456");
        public FormTrab()
        {
            InitializeComponent();
        }

        private void FormTrab_Load(object sender, EventArgs e)
        {
            con.ListarTrabajadores(dtbTrab);
            con.ListarVoluntarios(dtbVon);
            txtImpuesto.Visible = false;
            lbles.Visible = false;
            lblim.Visible = false;
            lblsal.Visible = false;
            txtESSA.Visible = false;
            txtSalario.Visible = false;
            txtHoras.Visible = false;
            lblh.Visible = false;
            btnTerm.Visible = false;
            btnDeleteV.Visible = false;
            btnUptV.Visible = false;
            lbllol.Visible = false;
        }
        public void cleanTextBox()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            cmbTipo.Text = "";
            txtEdad.Text = "";
            txtSalario.Text = "";
            txtESSA.Text = "";
            txtProf.Text = "";
            txtHoras.Text = "";
            txtImpuesto.Text = "";
        }
        public string res;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || cmbTipo.Text == "" || txtEdad.Text == "" || txtSalario.Text == "" ||txtESSA.Text == "" || txtProf.Text == "" || txtHoras.Text == "" || txtImpuesto.Text == "")
            {
                if(cmbTipo.Text == "")
                {
                    MessageBox.Show("Seleccione un tipo de trabajador");
                }
                if (cmbTipo.Text != "")
                {
                    MessageBox.Show("Los campos no pueden estar vacios");
                }
                
            }
            else 
            {

               
                con.SocioTrabajador(txtDNI.Text,lbllol);
                if(lbllol.Text != txtDNI.Text)
                {
                    con.ValidarAsalariado(txtDNI.Text, lbllol);

                    if(lbllol.Text ==txtDNI.Text)
                    {
                        MessageBox.Show("Este trabajador ya existe");
                    }
                    else
                    {
                        lbllol.Text = "";
                        con.ValidarVoluntario(txtDNI.Text, lbllol);
                        if(lbllol.Text == txtDNI.Text)
                        {
                            MessageBox.Show("Este trabajador ya existe");
                        }
                        else
                        { 
                        con.NuevoTrabajador(dtbTrab, txtDNI.Text, txtNombre.Text, cmbTipo.Text, txtEdad.Text, txtSalario.Text,
                        txtESSA.Text, txtProf.Text, txtHoras.Text, txtImpuesto.Text);
                        con.ListarTrabajadores(dtbTrab);
                        con.ListarVoluntarios(dtbVon);
                        cleanTextBox();
                        MessageBox.Show("Trabajador agregado correctamente");
                            lbllol.Text = "";
                        }
                    }
                }
              else
                {
                    MessageBox.Show("Ha insertado el DNI de un socio \n" +
                        "Un socio no puede ser trabajador");
                    lbllol.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == String.Empty)
            {
                MessageBox.Show("No ha seleccionado ningun Trabajador");
            }
            else
            {
                btnTerm.Visible = true;
                txtNombre.Enabled = true;
                txtEdad.Enabled = true;
                txtProf.Enabled = true;
                txtHoras.Enabled = true;
                txtESSA.Enabled = true;
                txtImpuesto.Enabled = true;
                txtSalario.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == String.Empty)
            {
                MessageBox.Show("No ha seleccionado ningun Trabajador");
            }
            else
            {
                con.EliminarTrabajador(dtbTrab, txtDNI.Text);
            MessageBox.Show("Trabajador eliminado correctamente");
            con.ListarTrabajadores(dtbTrab);
            cleanTextBox();
            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            txtProf.Enabled = true;
            txtHoras.Enabled = true;
            txtESSA.Enabled = true;
            txtImpuesto.Enabled = true;
            txtSalario.Enabled = true;
            cmbTipo.Enabled = true;
            btnTerm.Visible = false;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.Text == "voluntario")
            {

                txtImpuesto.Text = "0";
                txtESSA.Text = "0";
                txtSalario.Text = "0";
                txtHoras.Text = "";
                txtImpuesto.Visible = false;
                lbles.Visible = false;
                lblim.Visible = false;
                lblsal.Visible = false;
                txtESSA.Visible = false;
                txtSalario.Visible = false;
                txtHoras.Visible = true;
                lblh.Visible = true;
             

            }
            if (cmbTipo.Text == "asalariado")
            {
              
                txtImpuesto.Visible = true;
                txtProf.Visible= true;
                txtESSA.Visible = true;
                txtSalario.Visible = true;
                lbles.Visible = true;
                lblim.Visible = true;
                lblsal.Visible = true;
                txtHoras.Visible = false;
                lblh.Visible = false;
                txtHoras.Text= "0";
                txtProf.Text = "";
                txtImpuesto.Text = "";
                txtESSA.Text = "";
                txtSalario.Text = "";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtbTrab_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = dtbTrab.Rows[e.RowIndex];
            txtDNI.Text = Convert.ToString(fila.Cells[0].Value).Trim();
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value).Trim();
            txtEdad.Text = Convert.ToString(fila.Cells[2].Value).Trim();
            cmbTipo.Text = Convert.ToString(fila.Cells[4].Value).Trim();
            txtProf.Text = Convert.ToString(fila.Cells[5].Value).Trim();
            txtESSA.Text = Convert.ToInt32(fila.Cells[6].Value).ToString();
            txtImpuesto.Text = Convert.ToInt32(fila.Cells[7].Value).ToString();
            txtSalario.Text = Convert.ToInt32(fila.Cells[8].Value).ToString();
            txtHoras.Text = "0";
            txtDNI.Enabled = false;
            txtNombre.Enabled = false;
            txtEdad.Enabled = false;
            txtProf.Enabled = false;
            txtHoras.Enabled = false;
            txtESSA.Enabled = false;
            txtImpuesto.Enabled = false;
            txtSalario.Enabled = false;
            cmbTipo.Enabled = false;

            btnDeleteV.Visible = false;
            btnUptV.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
        }

        private void btnTerm_Click(object sender, EventArgs e)
        {
            cmbTipo.Enabled = true;
            if (txtDNI.Text == "" || txtNombre.Text == "" || cmbTipo.Text == "" || txtEdad.Text == "" || txtSalario.Text == "" || txtESSA.Text == "" || txtProf.Text == "" || txtHoras.Text == "" || txtImpuesto.Text == "")
            {
                if (cmbTipo.Text == "")
                {
                    MessageBox.Show("Seleccione un tipo de trabajador");
                }
                if (cmbTipo.Text != "")
                {
                    MessageBox.Show("Los campos no pueden estar vacios");
                }

            }
            else
            {
                con.ModificarTrabajador(dtbTrab, txtDNI.Text, txtNombre.Text, cmbTipo.Text, txtEdad.Text, txtSalario.Text,
                         txtESSA.Text, txtProf.Text, txtHoras.Text, txtImpuesto.Text);
                MessageBox.Show("Trabajador actualizado correctamente");
                con.ListarTrabajadores(dtbTrab);
                con.ListarVoluntarios(dtbVon);
                cleanTextBox();
                txtDNI.Enabled = true;
                txtNombre.Enabled = true;
                txtEdad.Enabled = true;
                txtProf.Enabled = true;
                txtHoras.Enabled = true;
                txtESSA.Enabled = true;
                txtImpuesto.Enabled = true;
                txtSalario.Enabled = true;
                cmbTipo.Enabled = true;
                btnTerm.Visible = false;
                btnAdd.Enabled = true;
            }
        }

        private void dtbVon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtbVon.Rows[e.RowIndex];
            txtDNI.Text = Convert.ToString(fila.Cells[0].Value).Trim();
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value).Trim();
            txtEdad.Text = Convert.ToString(fila.Cells[2].Value).Trim();
            cmbTipo.Text = "voluntario";
            txtProf.Text = Convert.ToString(fila.Cells[3].Value).Trim();
            txtHoras.Text = Convert.ToString(fila.Cells[4].Value).Trim();
            txtImpuesto.Text = "0";
            txtESSA.Text = "0";
            txtSalario.Text = "0";
            txtDNI.Enabled = false;
            txtNombre.Enabled = false;
            txtEdad.Enabled = false;
            txtProf.Enabled = false;
            txtHoras.Enabled = false;
            txtESSA.Enabled = false;
            txtImpuesto.Enabled = false;
            txtSalario.Enabled = false;
            cmbTipo.Enabled = false;

            btnDeleteV.Visible = true;
            btnUptV.Visible = true;

            button1.Visible = false;
            button2.Visible = false;

        }

        private void btnUptV_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == String.Empty)
            {
                MessageBox.Show("No ha seleccionado ningun Trabajador");
            }
            else
            {
                btnTerm.Visible = true;
                txtNombre.Enabled = true;
                txtEdad.Enabled = true;
                txtProf.Enabled = true;
                txtHoras.Enabled = true;
                txtESSA.Enabled = true;
                txtImpuesto.Enabled = true;
                txtSalario.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnDeleteV_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == String.Empty)
            {
                MessageBox.Show("No ha seleccionado ningun Trabajador");
            }
            else
            {
                con.EliminarTrabajador(dtbVon, txtDNI.Text);
            MessageBox.Show("Trabajador eliminado correctamente");
            con.ListarVoluntarios(dtbVon);
            cleanTextBox();
            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            txtProf.Enabled = true;
            txtHoras.Enabled = true;
            txtESSA.Enabled = true;
            txtImpuesto.Enabled = true;
            txtSalario.Enabled = true;
            cmbTipo.Enabled = true;
            btnTerm.Visible = false;
            }
        }

        private void txtEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
  !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
  !(e.KeyCode == Keys.Back) &&
  !(e.KeyCode == Keys.Delete) &&
  !(e.KeyCode == Keys.ControlKey) &&
  !(e.KeyCode == Keys.Control) &&
  //!(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
  //!(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
  //!(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
  !(e.KeyCode == Keys.Home) &&
  !(e.KeyCode == Keys.End) &&
  !(e.KeyCode == Keys.Left) &&
  !(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else
            {
                // Permitir solo dos dígitos
                if (txtEdad.TextLength == 2 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
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

        private void txtDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDNI.TextLength == 10 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtProf_KeyDown(object sender, KeyEventArgs e)
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

        private void txtHoras_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
!(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
!(e.KeyCode == Keys.Back) &&
!(e.KeyCode == Keys.Delete) &&
!(e.KeyCode == Keys.ControlKey) &&
!(e.KeyCode == Keys.Control) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
!(e.KeyCode == Keys.Home) &&
!(e.KeyCode == Keys.End) &&
!(e.KeyCode == Keys.Left) &&
!(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else
            {
                // Permitir solo dos dígitos
                if (txtHoras.TextLength == 4 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void txtESSA_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
!(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
!(e.KeyCode == Keys.Back) &&
!(e.KeyCode == Keys.Delete) &&
!(e.KeyCode == Keys.ControlKey) &&
!(e.KeyCode == Keys.Control) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
!(e.KeyCode == Keys.Home) &&
!(e.KeyCode == Keys.End) &&
!(e.KeyCode == Keys.Left) &&
!(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else
            {
                // Permitir solo dos dígitos
                if (txtESSA.TextLength == 8 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImpuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
!(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
!(e.KeyCode == Keys.Back) &&
!(e.KeyCode == Keys.Delete) &&
!(e.KeyCode == Keys.ControlKey) &&
!(e.KeyCode == Keys.Control) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
!(e.KeyCode == Keys.Home) &&
!(e.KeyCode == Keys.End) &&
!(e.KeyCode == Keys.Left) &&
!(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else
            {
                // Permitir solo dos dígitos
                if (txtSalario.TextLength == 2 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
!(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
!(e.KeyCode == Keys.Back) &&
!(e.KeyCode == Keys.Delete) &&
!(e.KeyCode == Keys.ControlKey) &&
!(e.KeyCode == Keys.Control) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.C) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.V) &&
//!(e.KeyCode == Keys.Control || e.KeyCode == Keys.A) &&
!(e.KeyCode == Keys.Home) &&
!(e.KeyCode == Keys.End) &&
!(e.KeyCode == Keys.Left) &&
!(e.KeyCode == Keys.Right))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else
            {
                // Permitir solo dos dígitos
                if (txtSalario.TextLength == 100 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleanTextBox();
            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            txtProf.Enabled = true;
            txtHoras.Enabled = true;
            txtESSA.Enabled = true;
            txtImpuesto.Enabled = true;
            txtSalario.Enabled = true;
            cmbTipo.Enabled = true;
            btnTerm.Visible = false;
            btnAdd.Enabled = true;
        }
    }
}
