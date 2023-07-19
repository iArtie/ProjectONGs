using System.Windows.Forms;

namespace ONGs.Formularios
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            Hide();
        }

        private void asociacionesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormAso Asos = new FormAso();
            Asos.MdiParent = this;
            Asos.Show();
        }

        private void sOCIOSToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSocios sos = new FormSocios();
            sos.MdiParent = this;
            sos.Show();
        }

        private void tRABAJADORESToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormTrab trab = new FormTrab();
            trab.MdiParent = this;
            trab.Show();
        }

        private void pROYECTOSToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormProyectos proy = new FormProyectos();
            proy.MdiParent = this;
            proy.Show();
        }

        private void sUBPROYECTOSToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSubProy subProy = new FormSubProy();
            subProy.MdiParent = this;
            subProy.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmReport report = new FrmReport();
            report.MdiParent = this;
            report.Show();
        }
    }
}
