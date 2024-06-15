using Microsoft.VisualStudio.TestTools.UnitTesting;
using paskaita_16_dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace paskaita_16_dictionary.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CountriesAndCapitalsTest()
        {
            // Arrange
            string expected = "Vilnius";
            string actual;
            string salis = "Lietuva";

            // Act
            actual = Program.CountriesAndCapitals(salis);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DictionaryOfFruitsTest()
        {
            // Arrange
            Dictionary<string, int> fruits = new Dictionary<string, int>
            {
                { "Obuolys", 5 },
                { "Kriause", 10 },
                { "Slyva", 15 }
            };
            string fruit = "Obuolys";
            int amount = 5;
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "Obuolys", 10 },
                { "Kriause", 10 },
                { "Slyva", 15 }
            };

            // Act
            Program.DictionaryOfFruits(fruits, fruit, amount);

            // Assert
            CollectionAssert.AreEqual(expected, fruits);
        }
        [TestMethod()]
        public void DictionaryOfFruitsTest2() 
        {
            // Arrange
            Dictionary<string, int> fruits = new Dictionary<string, int>
            {
                { "Obuolys", 5 },
                { "Kriause", 10 },
                { "Slyva", 15 }
            };
            string fruit = "Bananas";
            int amount = 5;
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "Obuolys", 5 },
                { "Kriause", 10 },
                { "Slyva", 15 },
                { "Bananas", 5 }
            };

            // Act
            Program.DictionaryOfFruits(fruits, fruit, amount);

            // Assert
            CollectionAssert.AreEqual(expected, fruits);
        }
    }
}