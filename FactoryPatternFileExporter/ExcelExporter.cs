using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternFileExporter
{
    public class ExcelExporter : IDocumentExporter
    {
        public void Export(string content)
        {
            Console.WriteLine("Exporting report as Excel...");
            Console.WriteLine($"Content: {content}");
        }
    }
}
