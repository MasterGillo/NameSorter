using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Interfaces;
using NameSorter.Models;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter.Tests
{
    [TestClass]
    public class PersonNameCollectionTests
    {
        private IPersonNameSorter personNameSorter;
        private IPersonNameCollection personNameCollection;

        [TestInitialize]
        public void InitialiseTest()
        {
            personNameSorter = new PersonNameSorter();
            personNameCollection = new PersonNameCollection(personNameSorter);
        }


        [TestMethod]
        public void AddNamesToCollection()
        {
            //Arrange
            var nameList = new List<string>(new[]
                { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer" });

            //Act
            personNameCollection.AddList(nameList);

            //Assert
            Assert.AreEqual(new PersonName("Parsons", "Janet").FullName, personNameCollection.PersonNames[0].FullName);
            Assert.AreEqual(new PersonName("Lewis", "Vaughn").FullName, personNameCollection.PersonNames[1].FullName);
            Assert.AreEqual(new PersonName("Archer", "Adonis Julius").FullName, personNameCollection.PersonNames[2].FullName);
        }

        [TestMethod]
        public void SortCollection()
        {
            //Arrange
            var nameList = new List<string>(new[]
                { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer" });
            var orderedNameList = new List<string>(new[]
                { "Adonis Julius Archer", "Vaughn Lewis", "Janet Parsons" });

            //Act
            personNameCollection.AddList(nameList);
            personNameCollection.Sort();

            //Assert
            Assert.IsTrue(personNameCollection.PersonNames.Select(x => x.FullName).SequenceEqual(orderedNameList));
        }
    }
}
