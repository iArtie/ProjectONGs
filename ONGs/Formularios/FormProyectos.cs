using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ONGs.Formularios
{
    public partial class FormProyectos : Form
    {
        Conexion con = new Conexion("sa", "123456");
        public FormProyectos()
        {
            InitializeComponent();
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {
            con.ListarProyectos(dtbProy);
            btnTerm.Visible= false;
            lblValidate.Visible= false;
        }

        public void clearT()
        {
            txtAso.Text = string.Empty;
            //txtNombre.Text = string.Empty;
            txtPais.Text = string.Empty;
            txtZona.Text = string.Empty;
            txtObj.Text = string.Empty;
            txtBen.Text = string.Empty;
            txtDNI.Text = string.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAso.Text == string.Empty ||
            //txtNombre.Text == string.Empty ||
            txtPais.Text == string.Empty ||
            txtZona.Text == string.Empty ||
            txtObj.Text == string.Empty ||
            txtBen.Text == string.Empty||
            txtDNI.Text == string.Empty)
            {
                MessageBox.Show("No se puede agregar porque hay casillas en blanco");
            }
            else 
            {
             
                  
                con.ValidarAsociacion(txtAso.Text, lblValidate);

                if(lblValidate.Text == txtAso.Text) 
                {
                    con.ValidarAsalariado(txtDNI.Text, lblValidate);

                    if (lblValidate.Text == txtDNI.Text)
                    {
                        con.NuevoProyecto(dtbProy, txtAso.Text, txtPais.Text, txtZona.Text, txtObj.Text,
                        txtBen.Text, txtDNI.Text);
                        MessageBox.Show("Proyecto agregado correctamente");
                        clearT();
                        con.ListarProyectos(dtbProy);
                        lblValidate.Text = "";
                    }
                    else
                    {
                        lblValidate.Text = "";
                        con.ValidarVoluntario(txtDNI.Text, lblValidate);
                        if (lblValidate.Text == txtDNI.Text)
                        {
                            //con.NuevoProyecto(dtbProy, txtAso.Text, txtPais.Text, txtZona.Text, txtObj.Text,
                            //txtBen.Text, txtDNI.Text);
                            //MessageBox.Show("Proyecto agregado correctamente");
                            //clearT();
                            //con.ListarProyectos(dtbProy);
                            //lblValidate.Text = "";
                            MessageBox.Show("Solo pueden agregarse trabajadores asalariados");
                            lblValidate.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("El trabajador que intenta agregar no existe");
                        }
                    }
                }  
               else
                {
                    MessageBox.Show("La asociacion que intenta agregar no existe");
                }



            }
        }
        public string valcan;
        private void dtbProy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtbProy.Rows[e.RowIndex];
            valcan = Convert.ToString(fila.Cells[0].Value);
            valcan = valcan.Trim();
            txtAso.Text = Convert.ToString(fila.Cells[1].Value).Trim();
            txtPais.Text = Convert.ToString(fila.Cells[2].Value).Trim();
            txtZona.Text = Convert.ToString(fila.Cells[3].Value).Trim();
            txtObj.Text = Convert.ToString(fila.Cells[4].Value).Trim();
            txtBen.Text = Convert.ToString(fila.Cells[5].Value).Trim();
            txtDNI.Text = Convert.ToString(fila.Cells[6].Value).Trim();
            lblID.Text = valcan;

            txtAso.Enabled = false;
            txtPais.Enabled = false;
            txtZona.Enabled = false;
            txtObj.Enabled = false;
            txtBen.Enabled = false;
            txtDNI.Enabled = false;
        }

        private void btnTerm_Click(object sender, EventArgs e)
        {
            if (txtAso.Text == string.Empty ||
            //txtNombre.Text == string.Empty ||
            txtPais.Text == string.Empty ||
            txtZona.Text == string.Empty ||
            txtObj.Text == string.Empty ||
            txtBen.Text == string.Empty ||
            txtDNI.Text == string.Empty)
            {
                MessageBox.Show("No se puede actualizar porque hay casillas en blanco");
            }
            else
            {
                con.ValidarAsalariado(txtDNI.Text, lblValidate);

                if (lblValidate.Text == txtDNI.Text)
                {
                    con.ModificarProyecto(dtbProy, lblID.Text, txtAso.Text, txtPais.Text, txtZona.Text, txtObj.Text,
                   txtBen.Text, txtDNI.Text);
                    MessageBox.Show("Proyecto actualizado correctamente");
                    clearT();
                    con.ListarProyectos(dtbProy);
                    valcan = null;
                    lblID.Text = string.Empty;
                    btnTerm.Visible = false;
                    lblValidate.Text = "";
                    btnAdd.Enabled = true;
                }
                else
                {
                    lblValidate.Text = "";
                    con.ValidarVoluntario(txtDNI.Text, lblValidate);
                    if (lblValidate.Text == txtDNI.Text)
                    {
                        //     con.ModificarProyecto(dtbProy, lblID.Text, txtAso.Text, txtPais.Text, txtZona.Text, txtObj.Text,
                        //txtBen.Text, txtDNI.Text);
                        //     MessageBox.Show("Proyecto actualizado correctamente");
                        //     clearT();
                        //     con.ListarProyectos(dtbProy);
                        //     valcan = null;
                        //     lblID.Text = string.Empty;
                        //     btnTerm.Visible = false;
                        MessageBox.Show("Solo pueden agregarse trabajadores asalariados");
                        lblValidate.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El trabajador que intenta agregar no existe");
                    }
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (valcan == null)
            {
                MessageBox.Show("No tiene ningun proyecto seleccionado");
            }
            else
            {

                btnTerm.Visible = true;
                txtAso.Enabled = false;
                txtPais.Enabled = true;
                txtZona.Enabled = true;
                txtObj.Enabled = true;
                txtBen.Enabled = true;
                txtDNI.Enabled = true;
                btnAdd.Enabled = false;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valcan == null)
            {
                MessageBox.Show("No tiene ningun proyecto seleccionado");
            }
            else
            {
                con.EliminarProyecto(dtbProy,valcan);
                MessageBox.Show("Proyecto eliminado correctamente");
                clearT();
                con.ListarProyectos(dtbProy);
                valcan = null;
                lblID.Text = string.Empty;
                txtAso.Enabled = true;
                txtPais.Enabled = true;
                txtZona.Enabled = true;
                txtObj.Enabled = true;
                txtBen.Enabled = true;
                txtDNI.Enabled = true;
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
                if (txtAso.TextLength == 8 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
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
            con.ListarProyectos(dtbProy);
            valcan = null;
            lblID.Text = string.Empty;
            txtAso.Enabled = true;
            txtPais.Enabled = true;
            txtZona.Enabled = true;
            txtObj.Enabled = true;
            txtBen.Enabled = true;
            txtDNI.Enabled = true;
            btnTerm.Visible = false;
            btnAdd.Enabled = true;
        }
    }
}
