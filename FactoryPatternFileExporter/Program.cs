using FactoryPatternFileExporter;

class Program
{
    static void Main()
    {
        IDocumentExporter exporter =
            new PdfExporter();
        exporter.Export("Annual Sales Report");
        IDocumentExporter exporter1 =
            new WordExporter();
        exporter1.Export("Annual Sales Report");
        IDocumentExporter exporter2 =
            new ExcelExporter();
        exporter.Export("Annual Sales Report");
    }
}