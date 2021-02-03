using NameSorter.Interfaces;
using Ninject.Modules;

namespace NameSorter
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IFileReader>().To<FileReader>();
            Bind<IFileWriter>().To<FileWriter>();
            Bind<IPersonNameCollection>().To<PersonNameCollection>();
            Bind<IPersonNameSorter>().To<PersonNameSorter>();
        }
    }
}
