using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.rtf.table;
using System.Collections;
using Font = iTextSharp.text.Font;
//using Font = System.Drawing.Font;

namespace ONGs.Formularios
{
    public partial class FrmReport : Form
    {
        public int lol = 0;
        Conexion con = new Conexion("sa", "123456");
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {


        }
    
        private void button1_Click(object sender, EventArgs e)
        {

           if(dtbPrint.DataSource == null)
            {
                MessageBox.Show("No ha seleccionado ninguna lista");

            }
            else { 


            if(lol == 0)
            {
                    try
                    {
                        using (Document document = new Document())
                        {
                            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reporte.pdf");
                            using (PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create)))
                            {
                                FontFamily fontFamily = new FontFamily("Arial");
                                var MyFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 18.ToString(), true);
                                //Font font = new Font(fontFamily,16, FontStyle.Bold);
                                document.Open();
                                Paragraph p = new Paragraph(lblList.Text, MyFont);
                                p.Alignment = Element.ALIGN_CENTER;
                                //p.Font = font;
                                document.Add(p);

                                Paragraph p1 = new Paragraph(" ");
                                p1.Alignment = Element.ALIGN_CENTER;
                                //p.Font = font;
                                document.Add(p1);

                                Paragraph p2 = new Paragraph(" ");
                                p2.Alignment = Element.ALIGN_CENTER;
                                //p.Font = font;
                                document.Add(p2);
                                // Agregar las columnas
                                PdfPTable pdfTable = new PdfPTable(dtbPrint.Columns.Count);
                                for (int j = 0; j < dtbPrint.Columns.Count; j++)
                                {
                                    pdfTable.AddCell(new Phrase(dtbPrint.Columns[j].HeaderText));
                                }

                                // Agregar las filas
                                for (int i = 0; i < dtbPrint.Rows.Count; i++)
                                {
                                    for (int k = 0; k < dtbPrint.Columns.Count; k++)
                                    {
                                        if (dtbPrint[k, i].Value != null)
                                        {
                                            pdfTable.AddCell(new Phrase(dtbPrint[k, i].Value.ToString()));
                                        }
                                    }
                                }

                                // Agregar la tabla al documento
                                document.Add(pdfTable);
                                document.Close();
                                writer.Close();

                                writer.CloseStream = true;

                                //// Cerrar documento
                                //doc.Close();
                                //doc.Close();
                                //doc.Close();
                                //PdfWriter.GetInstance(doc, new FileStream("Reporte.pdf", FileMode.Create));

                                MessageBox.Show("Reporte guardado en Documentos! \n " +
                                    "\n" +
                                    "NOTA: Para hacer otro reporte debera de cerrar la aplicacion y volverla a abrir");
                                lol = 12;
                                dtbPrint.DataSource = null;
                                cmbPrint.SelectedItem = null;
                                lblList.Text = "";
                                // ... agregar contenido al documento ...
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("No se puede realizar el reporte debido a que ya fue realizado previamente.\n" +
                            "para volver a realizar el reporte cierre y vuelva a abrir el programa");
                        dtbPrint.Enabled = false;
                        cmbPrint.Enabled = false;
                    }
                    //Document doc = new Document();
                    //string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reporte.pdf");
                    //PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                    //PdfWriter.GetInstance(doc, new FileStream("Reporte.pdf", FileMode.Create));
                    // Añadir contenido

                }
            else 
            {
                MessageBox.Show("El reporte ya ha sido creado! porfavor cierre el programa y vuelva a abrir");
                    dtbPrint.Enabled = false;
                    cmbPrint.Enabled = false;
                }


                //dtbReport.DataSource = dt;



                //guardardoc(doc);

                //Close();
                //Dispose();
            }
        }

        private void FrmReport_Load_1(object sender, EventArgs e)
        {
           
        }

        private void cmbPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPrint.Text == "Lista de Asociaciones")
            {
                lblList.Text = "Asociaciones";
                con.ListarAsociaciones(dtbPrint);
            }

            if (cmbPrint.Text == "Lista de Socios")
            {
                lblList.Text = "Socios";
                con.ListarSocios(dtbPrint);
            }

            if (cmbPrint.Text == "Lista de Trabajadores Asalariados")
            {
                lblList.Text = "Asalariados";
                con.ListarTrabajadores(dtbPrint);
            }
            

            if (cmbPrint.Text == "Lista de Trabajadores Voluntarios")
            {
                lblList.Text = "Voluntarios";
                con.ListarVoluntarios(dtbPrint);
            }

            if (cmbPrint.Text == "Lista de Proyectos")
            {
                lblList.Text = "Proyectos";
                con.ListarProyectos(dtbPrint);
            }

            if (cmbPrint.Text == "Lista de SubProyectos")
            {
                lblList.Text = "SubProyectos";
                con.ListarSubProyectos(dtbPrint);
            }
            
        }
    }
}
