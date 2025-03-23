using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace PdfGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the output file path
            string outputPath = "output.pdf";

            // Create a PDF writer
            using (PdfWriter writer = new PdfWriter(outputPath))
            {
                // Initialize the PDF document
                PdfDocument pdf = new PdfDocument(writer);

                // Create a document to add content
                Document document = new Document(pdf);

                // Add a paragraph to the document
                document.Add(new Paragraph("Hello, this is a PDF generated using iText 7 in .NET Core!"));

                // Close the document
                document.Close();
            }

            Console.WriteLine($"PDF generated successfully at {outputPath}");
        }
    }
}