using NameSorter.Interfaces;
using Ninject;
using System;
using System.Reflection;

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

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var fileReader = kernel.Get<IFileReader>();
            var fileWriter = kernel.Get<IFileWriter>();
            var personNameCollection = kernel.Get<IPersonNameCollection>();

            var nameSorter = new NameSorter(fileReader, fileWriter, personNameCollection);
            nameSorter.Process(args[0]);
            Console.ReadLine();
        }
    }
}
