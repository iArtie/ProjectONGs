using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ONGs.Formularios
{
    public partial class FormSocios : Form
    {
        Conexion con = new Conexion("sa", "123456");
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            con.ListarSocios(dtbSocios);
            btnTerm.Visible= false;
            lblVal.Visible= false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtDir.Text == "" || txtProv.Text == "" || txtCuota.Text == "" || txtAso.Text == "")
            {
                MessageBox.Show("No se pudo agregar porque hay casillas en blanco");
            }
            else 
            {
                con.SocioTrabajador(txtDNI.Text,lblVal);

                if(lblVal.Text == txtDNI.Text)
                {
                    MessageBox.Show("El socio que intenta agregar ya existe");
                    lblVal.Text = "";
                }
                else
                {
                    lblVal.Text = "";
                    con.ValidarAsociacion(txtAso.Text, lblVal);

                    if (lblVal.Text != "empty")
                    {
                        con.NuevoSocio(dtbSocios, txtDNI.Text, txtNombre.Text, txtDir.Text, txtProv.Text, txtCuota.Text, txtAso.Text);
                        MessageBox.Show("Socio agregado correctamente");
                        con.ListarSocios(dtbSocios);
                        clearT();
                        lblVal.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("La asociacion a la que intenta ingresar el socio no existe");
                    }
                }
               
            }
            
        }
        public string valcan;
        public int cuota = 0, aso = 0;
        private void dtbSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtbSocios.Rows[e.RowIndex];
            txtDNI.Text = Convert.ToString(fila.Cells[0].Value).Trim();
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value).Trim();
            txtDir.Text = Convert.ToString(fila.Cells[2].Value).Trim();
            txtProv.Text = Convert.ToString(fila.Cells[3].Value).Trim();
            //txtCuota.Text = Convert.ToString(fila.Cells[5].Value).Trim();
            //txtAso.Text = Convert.ToString(fila.Cells[6].Value).Trim();
            cuota = Convert.ToInt32(fila.Cells[5].Value);
            aso = Convert.ToInt32(fila.Cells[7].Value);
            txtCuota.Text = cuota.ToString();
            txtAso.Text = aso.ToString();
            txtDNI.Enabled = false;
            txtNombre.Enabled = false;
            txtDir.Enabled = false;
            txtProv.Enabled = false;
            txtCuota.Enabled = false;
            txtAso.Enabled = false;
        }
        public void clearT()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtDir.Text = "";
            txtProv.Text = "";
            txtCuota.Text = "";
            txtAso.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDNI.Text == String.Empty)
            {
                MessageBox.Show("No ha seleccionado ningun socio");
            }
            else 
            {
                btnTerm.Visible = true;
                txtNombre.Enabled = true;
                txtDir.Enabled = true;
                txtProv.Enabled = true;
                txtCuota.Enabled = true;
                txtAso.Enabled = true;
                btnAdd.Enabled = false;
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == String.Empty)
            {
                MessageBox.Show("No ha seleccionado ningun socio");
            }
            else
            { 
                con.EliminarSocio(dtbSocios,txtDNI.Text);
            MessageBox.Show("Socio eliminado correctamente");
            con.ListarSocios(dtbSocios);
            clearT();
            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtDir.Enabled = true;
            txtProv.Enabled = true;
            txtCuota.Enabled = true;
            txtAso.Enabled = true;
            btnTerm.Visible = false;
            }
        }

        private void txtCuota_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números del 0 al 9, el signo menos como primer carácter, y las teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (txtCuota.Text.Length == 0))
            {
                e.Handled = true;
                e.Handled = false;
            }

            if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar == '-') && (txtCuota.Text.Length != 0))
            {
                MessageBox.Show("Solo se admiten numeros enteros");
            }

            
        }

        private void txtAso_KeyDown(object sender, KeyEventArgs e)
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
                if (txtAso.TextLength == 10 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
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

        private void txtDNI_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (txtDNI.TextLength == 10 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearT();
            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtDir.Enabled = true;
            txtProv.Enabled = true;
            txtCuota.Enabled = true;
            txtAso.Enabled = true;
            btnTerm.Visible = false;
            btnAdd.Enabled = true;
        }

        private void btnTerm_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtDir.Text == "" || txtProv.Text == "" || txtCuota.Text == "" || txtAso.Text == "")
            {
                MessageBox.Show("No se pudo actualizar porque hay casillas en blanco");
            }
            else
            {
                con.ValidarAsociacion(txtAso.Text, lblVal);

                if (lblVal.Text != "empty")
                {
                    con.ModificarSocio(dtbSocios, txtDNI.Text, txtNombre.Text, txtDir.Text, txtProv.Text, txtCuota.Text, txtAso.Text);
                MessageBox.Show("Socio actualizado correctamente");
                con.ListarSocios(dtbSocios);
                clearT();
                txtDNI.Enabled = true;
                btnTerm.Visible = false;
                    btnAdd.Enabled = true;
                    lblVal.Text = "";
                }
                else
                {
                    MessageBox.Show("La asociacion a la que intenta ingresar el socio no existe");
                }
            }
        }
    }
}
