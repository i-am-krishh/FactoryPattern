using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternFileExporter
{
    public class WordExporter : IDocumentExporter
    {
        public void Export(string content)
        {
            Console.WriteLine("Exporting report as Word...");
            Console.WriteLine($"Content: {content}");
        }
    }
}