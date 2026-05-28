using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternFileExporter
{
    public class PdfExporter : IDocumentExporter
    {
        public void Export(string content)
        {
            Console.WriteLine("Exporting report as PDF...");
            Console.WriteLine($"Content: {content}");
        }
    }
}
