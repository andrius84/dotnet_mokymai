using Microsoft.VisualStudio.TestTools.UnitTesting;
using paskaita_13_repeat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace paskaita_13_repeat.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void NullArray()
        {
            //Arrange
            string[] fuits = null;
            string[] expected = { };

            //Act
            string[] actual = Program.VaisiaiCreateArrayWithLetterCount(fuits);

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        [TestMethod()]
        public void EmptyArray()
        {
            //Arrange
            string[] fuits = { };
            string[] expected = { };

            //Act
            string[] actual = Program.VaisiaiCreateArrayWithLetterCount(fuits);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ArrayWithOneElement()
        {
            //Arrange
            string[] fuits = { "Obuolys" };
            string[] expected = { "Obuolys: 7" };

            //Act
            string[] actual = Program.VaisiaiCreateArrayWithLetterCount(fuits);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ArrayWithThreeElements() 
        {
            //Arrange
            string[] fuits = { "Obuolys", "Bananai", "Braškės" };
            string[] expected = { "Obuolys: 7", "Bananai: 7", "Braškės: 7" };

            //Act
            string[] actual = Program.VaisiaiCreateArrayWithLetterCount(fuits);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ArrayWithOneEmptyElement()
        {
            //Arrange
            string[] fuits = { "" };
            string[] expected = { ": 0" };

            //Act
            string[] actual = Program.VaisiaiCreateArrayWithLetterCount(fuits);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}

