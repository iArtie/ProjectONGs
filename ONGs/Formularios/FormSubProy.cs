using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ONGs.Formularios
{
    public partial class FormSubProy : Form
    {
        Conexion con = new Conexion("sa", "123456");
        public FormSubProy()
        {
            InitializeComponent();
        }

        private void FormSubProy_Load(object sender, EventArgs e)
        {
            con.ListarSubProyectos(dtbSub);
            btnTerm.Visible = false;
            lblVal.Visible= false;
        }

        public void clearTextBox()
        {
            txtProy.Text= string.Empty;
            txtNombre.Text= string.Empty;
            txtPais.Text= string.Empty;
            txtZona.Text= string.Empty; 
            txtObj.Text= string.Empty;
            txtBen.Text= string.Empty;
         
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtProy.Text == string.Empty ||
            txtNombre.Text == string.Empty ||
            txtPais.Text == string.Empty ||
            txtZona.Text == string.Empty ||
            txtObj.Text == string.Empty ||
            txtBen.Text == string.Empty
            )
            {
                MessageBox.Show("No se puede agregar porque hay casillas en blanco");
            }
            else 
            {
                con.ValidarProyecto(txtProy.Text, lblVal);

                if (txtProy.Text == lblVal.Text)
                {

                    con.NuevoSubProyecto(dtbSub, txtProy.Text, txtNombre.Text, txtPais.Text, txtZona.Text,
                        txtObj.Text, txtBen.Text);
                    MessageBox.Show("SubProyecto agregado correctamente");
                    clearTextBox();
                    con.ListarSubProyectos(dtbSub); 
                }
                else
                {
                    MessageBox.Show("El proyecto no existe");
                }
            }
        }
        public string valcan;
        private void dtbSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtbSub.Rows[e.RowIndex];
            valcan = Convert.ToString(fila.Cells[0].Value);
            valcan = valcan.Trim();
            lblID.Text = valcan;
            txtProy.Text = Convert.ToString(fila.Cells[1].Value).Trim();
            txtNombre.Text =  Convert.ToString(fila.Cells[2].Value).Trim();
            txtPais.Text = Convert.ToString(fila.Cells[3].Value).Trim();
            txtZona.Text = Convert.ToString(fila.Cells[4].Value).Trim();
            txtObj.Text = Convert.ToString(fila.Cells[5].Value).Trim();
            txtBen.Text = Convert.ToString(fila.Cells[6].Value).Trim();

            txtProy.Enabled = false;
            txtNombre.Enabled = false;
            txtPais.Enabled = false;
            txtZona.Enabled = false;
            txtObj.Enabled = false;
            txtBen.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(valcan == null)
            {
                MessageBox.Show("No ha seleccionado ningun SubProyecto");
            }
            else
            { 
            txtProy.Enabled = false;
            txtNombre.Enabled = true;
            txtPais.Enabled = true;
            txtZona.Enabled = true;
            txtObj.Enabled = true;
            txtBen.Enabled = true;
            btnTerm.Visible= true;
            btnAdd.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valcan == null)
            {
                MessageBox.Show("No ha seleccionado ningun subproyecto");
            }
            else
            {
                con.EliminarSubProyecto(dtbSub,valcan);
                //MessageBox.Show("SubProyecto eliminado correctamente");
                clearTextBox();
                con.ListarSubProyectos(dtbSub);
                valcan = null;
                lblID.Text = string.Empty;
            }
        }

        private void btnTerm_Click(object sender, EventArgs e)
        {
            if (valcan == null)
            {
                MessageBox.Show("No ha seleccionado ningun subproyecto");
            }
            else
            {
                con.ModificarSubProyecto(dtbSub, valcan, txtProy.Text, txtNombre.Text, txtPais.Text, txtZona.Text,
                      txtObj.Text, txtBen.Text);
                MessageBox.Show("SubProyecto actualizado correctamente");
                clearTextBox();
                con.ListarSubProyectos(dtbSub);
                valcan = null;
                lblID.Text = string.Empty;
                btnTerm.Visible = false;
                txtProy.Enabled = true;
                txtNombre.Enabled = true;
                txtPais.Enabled = true;
                txtZona.Enabled = true;
                txtObj.Enabled = true;
                txtBen.Enabled = true;
                btnTerm.Visible = false;
                btnAdd.Enabled = true;
            }
        }

        private void txtProy_KeyDown(object sender, KeyEventArgs e)
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
                if (txtProy.TextLength == 8 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
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

        private void txtPais_KeyDown(object sender, KeyEventArgs e)
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

        private void txtZona_KeyDown(object sender, KeyEventArgs e)
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

        private void txtBen_KeyDown(object sender, KeyEventArgs e)
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
                if (txtBen.TextLength == 8 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearTextBox();
         
            valcan = null;
            lblID.Text = string.Empty;
            btnTerm.Visible = false;
            txtProy.Enabled = true;
            txtNombre.Enabled = true;
            txtPais.Enabled = true;
            txtZona.Enabled = true;
            txtObj.Enabled = true;
            txtBen.Enabled = true;
            btnTerm.Visible = false;
            btnAdd.Enabled= true;
        }
    }
}
