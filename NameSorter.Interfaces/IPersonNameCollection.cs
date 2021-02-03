using NameSorter.Models;
using System.Collections.Generic;

namespace NameSorter.Interfaces
{
    public interface IPersonNameCollection
    {
        List<PersonName> PersonNames { get; }
        void AddList(List<string> names);
        void Add(string lastName, string givenNames);
        void Add(PersonName personName);
        void Sort();
    }
}
