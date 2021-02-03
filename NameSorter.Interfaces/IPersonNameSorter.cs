using NameSorter.Models;
using System.Collections.Generic;

namespace NameSorter.Interfaces
{
    public interface IPersonNameSorter
    {
        List<PersonName> Sort(List<PersonName> nameList);
    }
}
