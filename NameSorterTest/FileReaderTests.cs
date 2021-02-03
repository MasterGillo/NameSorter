using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace NameSorter.Tests
{
    [TestClass]
    public class FileReaderTests
    {
        [TestMethod]
        public void ReadLinesWithValidFilePath()
        {
            //Arrange
            var nameList = new List<string>(new[]
                { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer" });

            const string filePath = "./UnitTest.txt";
            using (var streamWriter = File.CreateText(filePath))
            {
                foreach (var name in nameList)
                {
                    streamWriter.WriteLine(name);
                }
            }

            //Act
            var testList = FileReader.ReadLines(filePath);

            //Assert
            CollectionAssert.AreEqual(nameList, testList);
        }
    }
}