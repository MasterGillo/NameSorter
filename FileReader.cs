using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    /// <summary>
    /// Contains methods for reading and parsing files
    /// </summary>
    public static class FileReader
    {
        /// <summary>
        /// Reads files and converts lines to a list of strings
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>A list of strings; one for each line in the file.</returns>
        public static List<string> ReadLines(string filePath)
        {
            var result = new List<string>();
            var file = new StreamReader(filePath);
            string line;

            while ((line = file.ReadLine()) != null)
            {
                result.Add(line);
            }

            file.Close();

            return result;
        }
    }
}
