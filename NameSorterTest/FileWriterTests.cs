using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using System.Collections.Generic;
using System.IO;

namespace NameSorter.Tests
{
    [TestClass]
    public class FileWriterTests
    {
        [TestMethod]
        public void WriteFileWithValidPath()
        {
            //Arrange
            var nameList = new List<string>(new[]
                { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer" });
            const string filePath = "./UnitTest.txt";

            string line;
            var testList = new List<string>();

            //Act
            FileWriter.WriteLines(filePath, nameList);

            //Assert
            var file = new StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                testList.Add(line);
            }

            file.Close();

            CollectionAssert.AreEqual(nameList, testList);
        }
    }
}
