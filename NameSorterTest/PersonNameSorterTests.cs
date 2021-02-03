using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Models;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter.Tests
{
    [TestClass]
    public class PersonNameSorterTests
    {
        private PersonNameSorter personNameSorter;

        [TestInitialize]
        public void InitialiseTest()
        {
            personNameSorter = new PersonNameSorter();
        }

        [TestMethod]
        public void SortPersonNames()
        {
            //Arrange
            var nameList = new List<PersonName>
            (new[]
                {
                    new PersonName("Parsons", "Janet"),
                    new PersonName("Lewis", "Vaughn"),
                    new PersonName("Archer", "Adonis Julius")
                }
            );

            var orderedNameList = new List<PersonName>
            (new[]
                {
                    new PersonName("Archer", "Adonis Julius"),
                    new PersonName("Lewis", "Vaughn"),
                    new PersonName("Parsons", "Janet")
                }
            );

            //Act
            var result = personNameSorter.Sort(nameList);

            //Assert
            Assert.IsTrue(result.Select(x => x.FullName).SequenceEqual(orderedNameList.Select(x => x.FullName)));
        }
    }
}
