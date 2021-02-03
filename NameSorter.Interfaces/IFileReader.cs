using System.Collections.Generic;

namespace NameSorter.Interfaces
{
    public interface IFileReader
    {
        List<string> ReadLines(string filePath);
    }
}
