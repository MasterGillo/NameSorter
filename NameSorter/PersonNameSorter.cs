using NameSorter.Interfaces;
using NameSorter.Models;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public class PersonNameSorter : IPersonNameSorter
    {
        public List<PersonName> Sort(List<PersonName> personNames)
        {
            return personNames.OrderBy(x => x.LastName).ThenBy(x => x.GivenNames).ToList();
        }
    }
}
