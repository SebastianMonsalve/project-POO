using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace Sistema_de_facturacion.Formularios
{
    public partial class Prueba : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public Prueba()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var arq = @"C:\Users\sebas\Documents\RegistroCivil.pdf";
            openfile(arq);

            //if(dialog.ShowDialog() == DialogResult.OK)
            //{
            //    openfile(dialog.FileName);
            //}
        }
        public void openfile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }

    }
}
