using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternFileExporter
{
    public interface IDocumentExporter
    {
        void Export(string content);
    }
}
