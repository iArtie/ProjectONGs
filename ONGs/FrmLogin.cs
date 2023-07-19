using iTextSharp.text;
using ONGs.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONGs
{
    public partial class FrmLogin : Form
    {
        Conexion con = new Conexion("sa", "123456");
        int cont = 6;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        BackgroundWorker bg = new BackgroundWorker();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public  void clearTextBox()
        {
            txtUser.Text= string.Empty;
            txtPass.Text= string.Empty;
        }
        private void bg_DoWork(object sender, EventArgs e)
        {
            int progreso = 0, porciento = 0;


            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i);
            }
        }

        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbLogin.Value = e.ProgressPercentage;
            pgbLogin.Style = ProgressBarStyle.Continuous;


            if (e.ProgressPercentage > 100)
            {
                lblPer.Text = "100%";
                pgbLogin.Value = pgbLogin.Maximum;
            }
            else
            {
                lblPer.Text = Convert.ToString(e.ProgressPercentage) + "%";
                pgbLogin.Value = e.ProgressPercentage;
            }


        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            FrmMain main = new FrmMain();
            main.Show();
            Hide();

        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (txtUser.Text == String.Empty || txtPass.Text == String.Empty)
            {
                MessageBox.Show("Campos vacios");
            }
            else 
            {
                con.ValidarAcceso(txtUser.Text, txtPass.Text,lblres);
                if(lblres.Text == "Acceso Exitoso")
                {
                    bg.WorkerReportsProgress = true;
                    bg.ProgressChanged += bg_ProgressChanged;
                    bg.DoWork += bg_DoWork;
                    bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                    bg.RunWorkerAsync();
                    lblPer.Visible = true;
                    pgbLogin.Visible = true;
                    txtUser.Enabled =false;
                    txtPass.Enabled = false;
                    btnAccept.Enabled = false;
                    btnExit.Enabled = false;
                    lblPer.Visible = true;
                }
                else 
                {
                    Cursor.Current = Cursors.Default;
                    --cont;
                    label4.Visible = true;
                    lblTrys.Text = cont.ToString();
                    //MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                    if (cont == 0)
                    {
                        cont = 5;
                        btnAccept.Enabled = false;
                        btnExit.Enabled = false;
                        Thread.Sleep(3000);
                        btnAccept.Enabled = true;
                        btnExit.Enabled = true;
                        lblTrys.Text = cont.ToString();
                    }
                }
                clearTextBox();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblres.Visible = false;
            label4.Visible = false;
            pgbLogin.Visible = false;
            lblPer.Visible = false;
        }
    }
}



