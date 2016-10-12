using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// These 3 namespaces are needed to create a pdf file
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDFversion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // after downloading the itext file, you need to add the .dll to the referneces
        private void button1_Click(object sender, EventArgs e)
        {
            // first, create the filestream that will be written, and naming the .pdf file it self
            FileStream fs = new FileStream("Applicant_name_code.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            /* before creating the pdf file, you need to define its size. IText uses points [72 points = 1 inch]. It is important that
            the itext rectangle and System rectangle are distinguished.*/
            iTextSharp.text.Rectangle pdfSize = new iTextSharp.text.Rectangle(PageSize.A4);
            // create an instnace of the codument class to, then parse the pdfsize into this new document.
            Document createPDF = new Document(pdfSize);
            PdfWriter writer = PdfWriter.GetInstance(createPDF, fs);
            // open() allows us to add the content to the pdf file.
            createPDF.Open();
            // This will be expanded later to include the content of the template/feedback.
            createPDF.Add(new Paragraph("This is a test"));
            createPDF.Close();

            //So far this only creates the 1 pdf and it is created under the //PDFversion1//bin//DeBug
        }
    }
}
