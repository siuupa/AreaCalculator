using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Program program;

        [TestInitialize]
        public void Setup()
        {
            //Arrange
            program = new Program();
        }

        [TestMethod]
        public void AreaOfTriangle_CalculateAreaOfTringleGivenTwoArguments_ShouldReturnCorrectArea()
        {
            //Act
            var result = program.AreaOfTriangle(a: 5, h: 3);

            //Assert
            Assert.AreEqual(7.5, result);
        }

        [TestMethod]
        public void AreaOfSquare_CalculateAreaOfSquareGivenOneArgument_ShouldReturnCorrectArea()
        {
            //Act
            var result = program.AreaOfSquare(a: 5);

            //Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void AreaOfRectangle_CalculateAreaOfRectangleGivenTwoArguemnts_ShouldReturnCorrectArea()
        {
            //Act
            var result = program.AreaOfRectangle(a: 10, b: 8);

            //Assert
            Assert.AreEqual(80, result);
        }

        [TestMethod]
        public void AreaOfTrapeze_CalculateAreaOfTrapezeGivenThreeArguments_ShouldReturnCorrectArea()
        {
            //Act
            var result = program.AreaOfTrapeze(a: 5, b: 10, h: 8);

            //Assert
            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void AreaOfCircle_CalculateAreaOfCircleGivenOneArgument_ShouldReturnCorrectArea()
        {
            //Act
            var result = program.AreaOfCircle(r: 5);

            //Assert
            Assert.AreEqual(78.5, result);
        }
    }
}
