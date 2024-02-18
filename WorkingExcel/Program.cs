using PdfSharpCore.Drawing;
using PdfSharpCore.Drawing.Layout;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace WorkingExcel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to converter : ");
            TXTtoPDf();
        }

        public static void TXTtoPDf()
        {
            string textFilePath = @"C:\Users\abdur\OneDrive\Рабочий стол\text.txt";
            string pdfFilePath = @"C:\Users\abdur\OneDrive\Рабочий стол\pdf.pdf";

            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Add a new page to the document
            PdfPage page = document.AddPage();

            // Create a drawing object to draw on the page
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Read the text file and draw its content on the PDF page
            XFont font = new XFont("Arial", 12);
            XTextFormatter tf = new XTextFormatter(gfx);

            // Set the page dimensions
            XRect rect = new XRect(40, 40, page.Width.Point - 80, page.Height.Point - 80);

            // Read the content of the text file
            string[] lines = File.ReadAllLines(textFilePath);

            // Draw the content on the PDF page
            foreach (string line in lines)
            {
                tf.DrawString(line, font, XBrushes.Black, rect, XStringFormats.TopLeft);
                rect = new XRect(rect.Left, rect.Top + font.GetHeight(), rect.Width, rect.Height);
            }

            // Save the PDF document
            document.Save(pdfFilePath);

            Console.WriteLine("Conversion completed successfully.");
        }
    }
}
