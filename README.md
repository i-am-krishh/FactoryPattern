# Factory Pattern File Exporter

This project is a simple demonstration of the Factory Pattern in C# for exporting files in different formats.

## Description

The project consists of a `IDocumentExporter` interface and several concrete implementations for different file formats like `ExcelExporter`, `PdfExporter`, and `WordExporter`. A factory class is used to create instances of these exporters based on the desired file type.

## Usage

To use the file exporter, you can create an instance of the `DocumentExporterFactory` and call the `CreateExporter` method with the desired file type. This will return an instance of the corresponding exporter, which you can then use to export your document.

```csharp
// Example usage
IDocumentExporter exporter = DocumentExporterFactory.CreateExporter("excel");
exporter.Export("MyDocument");
```
