using FigureArea;

namespace Test.FigureArea
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void GetAreaTriangle_CorrectParam_CorrectResult()
        {
            // Arrange
            var sides = new List<double> { 4, 4, 4 };
            var expected = 6.9282;

            // Act
            var triangle = new Triangle(sides);
            var actual = Area.GetArea(triangle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAreaCircle_CorrectParam_CorrectResult()
        {
            // Arrange
            var circle = new Circle(10);
            var expected = 314.1593;

            // Act
            var actual = Area.GetArea(circle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
