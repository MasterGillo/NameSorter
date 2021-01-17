using System;
using System.Linq;

namespace NameSorter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a .txt file as an argument.");
                return;
            }

            var nameList = FileReader.ReadLines(args[0]);

            var personNameCollection = new PersonNameCollection();
            personNameCollection.Add(nameList);
            personNameCollection.Sort();

            FileWriter.WriteLines("./sorted-names-list.txt", personNameCollection.PersonNames.Select(x => x.FullName).ToList());
        }
    }
}
