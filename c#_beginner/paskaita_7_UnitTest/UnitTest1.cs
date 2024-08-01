using paskaita_7;

namespace paskaita_7_UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ReturnSum()
        {
            //arrange
            int number1 = 4;
            int number2 = 6;

            //act
            double answer = Program.Sum(number1, number2);

            Assert.AreEqual(answer,10);
        }
        [Test]
        public void ReturnSubstraction()
        {
            //arrange
            int number1 = 4;
            int number2 = 6;

            //act
            double answer = Program.Subtract(number1, number2);

            Assert.AreEqual(answer, -2);
        }
        [Test]
        public void ReturnMultiplication()
        {
            //arrange
            int number1 = 60;
            int number2 = 6;

            //act
            double answer = Program.Multiply(number1, number2);

            Assert.AreEqual(answer, 360);
        }
        [Test]
        public void ReturnDivision()
        {
            //arrange
            int number1 = 12;
            int number2 = 6;

            //act
            double answer = Program.Divide(number1, number2);

            Assert.AreEqual(answer, 2);
        }
        [Test]
        public void ReturnPower()
        {
            //arrange
            int number1 = 4;
            int number2 = 6;

            //act
            double answer = Program.NumberByDegree(number1, number2);

            Assert.AreEqual(answer, 4096);
        }
    }
}