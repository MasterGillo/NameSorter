using NameSorter.Models;
using System.Collections.Generic;

namespace NameSorter.Interfaces
{
    public interface IPersonNameCollection : ISortable
    {
        List<PersonName> PersonNames { get; }
        void Add(List<string> names);
    }
}
