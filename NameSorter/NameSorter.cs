using NameSorter.Interfaces;
using System;
using System.Linq;

namespace NameSorter
{
    public class NameSorter
    {
        private readonly IFileReader fileReader;
        private readonly IFileWriter fileWriter;
        private readonly IPersonNameCollection personNameCollection;

        public NameSorter(IFileReader fileReader, IFileWriter fileWriter, IPersonNameCollection personNameCollection)
        {
            this.fileReader = fileReader;
            this.fileWriter = fileWriter;
            this.personNameCollection = personNameCollection;
        }

        public void Process(string filePath)
        {
            var nameList = fileReader.ReadLines(filePath);

            personNameCollection.AddList(nameList);
            personNameCollection.Sort();

            fileWriter.WriteLines("./sorted-names-list.txt", personNameCollection.PersonNames.Select(x => x.FullName).ToList());

            foreach (var personName in personNameCollection.PersonNames)
            {
                Console.WriteLine(personName.FullName);
            }
        }
    }
}
