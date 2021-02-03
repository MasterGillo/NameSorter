﻿using NameSorter.Interfaces;
using NameSorter.Models;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    /// <summary>
    /// Manages a list of PersonNames 
    /// </summary>
    public class PersonNameCollection : IPersonNameCollection
    {
        private readonly IPersonNameSorter personNameSorter;
        public List<PersonName> PersonNames { get; private set; }

        public PersonNameCollection(IPersonNameSorter personNameSorter)
        {
            this.personNameSorter = personNameSorter;
            PersonNames = new List<PersonName>();
        }

        public void Add(PersonName personName)
        {
            PersonNames.Add(personName);
        }

        public void Add(string lastName, string givenNames)
        {
            Add(new PersonName(lastName, givenNames));
        }

        /// <summary>
        /// Adds to the list of person names from a list of strings
        /// </summary>
        /// <param name="names"></param>
        public void AddList(List<string> names)
        {
            foreach (var name in names)
            {
                var splitName = name.Split(" ");
                var lastName = splitName.Last();
                var givenNames = name.Substring(0, name.Length - (lastName.Length + 1));
                Add(lastName, givenNames);
            }
        }

        /// <summary>
        /// Sorts the list of person names by last name then given names
        /// </summary>
        public void Sort()
        {
            PersonNames = personNameSorter.Sort(PersonNames);

        }
    }
}
