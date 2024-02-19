using Aspose.Cells;

namespace WorkingExcel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string excelFilePath = @"C:\Users\abdur\OneDrive\Рабочий стол\excel.xlsx";
            string pdfFilePath = @"C:\Users\abdur\OneDrive\Рабочий стол\pdf.pdf";


            ConvertExcelToPdf(excelFilePath, pdfFilePath);

            Console.WriteLine("Excel to PDF conversion completed successfully.");
        }

        static void ConvertExcelToPdf(string excelFilePath, string pdfFilePath)
        {
            // Load the Excel workbook
            Workbook workbook = new Workbook(excelFilePath);

            // Save the workbook as PDF
            workbook.Save(pdfFilePath, SaveFormat.Pdf);
        }
    }
}
