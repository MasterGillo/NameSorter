using NameSorter.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    /// <summary>
    /// Contains methods for writing to files
    /// </summary>
    public class FileWriter : IFileWriter
    {
        /// <summary>
        /// Writes a list of strings to a file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="lines"></param>
        public void WriteLines(string filePath, List<string> lines)
        {
            using var streamWriter = File.CreateText(filePath);
            foreach (var line in lines)
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}
