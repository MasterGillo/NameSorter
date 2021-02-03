using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Interfaces;
using NameSorter.Models;
using System.Collections.Generic;

namespace NameSorter.Tests
{
    [TestClass]
    public class PersonNameCollectionTests
    {
        [TestMethod]
        public void AddNamesToCollection()
        {
            //Arrange
            var nameList = new List<string>(new[]
                { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer" });
            IPersonNameCollection personNameCollection = new PersonNameCollection();

            //Act
            personNameCollection.Add(nameList);

            //Assert
            Assert.AreEqual(new PersonName("Parsons", "Janet").FullName, personNameCollection.PersonNames[0].FullName);
            Assert.AreEqual(new PersonName("Lewis", "Vaughn").FullName, personNameCollection.PersonNames[1].FullName);
            Assert.AreEqual(new PersonName("Archer", "Adonis Julius").FullName, personNameCollection.PersonNames[2].FullName);
        }
    }
}
