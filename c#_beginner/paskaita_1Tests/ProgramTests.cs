using NUnit.Framework;
using paskaita_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace paskaita_1.Tests
{
    public class UnitTest
    {
        [Test]
        public void Skaicius_GivenNumberGreaterThan100_ReturnsCorrectMessage()
        {
            // Arrange
            int input = 101;

            // Act
            string result = Program.Skaicius(input);

            // Assert
            Assert.AreEqual("skaicius didesnis uz 100", result);
        }

        [Test]
        public void Slaptazodis_GivenPasswordWithLetters_ReturnsIncorrectPasswordMessage()
        {
            // Arrange
            string password = "111110000";
            int mypass = 11110000;

            // Act
            string result = Program.Slaptazodis(password, mypass);

            // Assert
            Assert.AreEqual("Slaptazodis neteisingas", result);
        }

        [Test]
        public void Slaptazodis_GivenCorrectPassword_ReturnsCorrectPasswordMessage()
        {
            // Arrange
            string password = "11110000";
            int mypass = 11110000;

            // Act
            string result = Program.Slaptazodis(password, mypass);

            // Assert
            Assert.AreEqual("Slaptazodis teisingas", result);
        }

        [Test]
        public void Slaptazodis_GivenIncorrectPassword_ReturnsIncorrectPasswordMessage()
        {
            // Arrange
            string password = "11110001";
            int mypass = 11110000;

            // Act
            string result = Program.Slaptazodis(password, mypass);

            // Assert
            Assert.AreEqual("Slaptazodis neteisingas", result);
        } 
    }
}