using NUnit.Framework;
using paskaita_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace paskaita_2.Tests
{
    [TestFixture()]
    public class ProgramTests
    {
        [Test]
        public void FigurosPlotasTest()
        {
            // Arrange
            string figura = "kvadratas";
            double expected = 16;
            // Act
            double actual = Program.FigurosPlotas(figura);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}