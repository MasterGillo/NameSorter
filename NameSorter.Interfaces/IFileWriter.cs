using System.Collections.Generic;

namespace NameSorter.Interfaces
{
    public interface IFileWriter
    {
        void WriteLines(string filePath, List<string> lines);
    }
}
