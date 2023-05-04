using FigureArea;

namespace Test.FigureArea
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Constructor_WithTreeParams_CorrectObject()
        {
            // Arrange

            // Act
            var triangle = new Triangle(3, 4, 5);

            // Assert
            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void Constructor_WithArray_CorrectObject()
        {
            // Arrange
            var sides = new double[3] { 3, 4, 5 };

            // Act
            var triangle = new Triangle(sides);

            // Assert
            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void Constructor_WithList_CorrectObject()
        {
            // Arrange
            var sides = new List<double> { 3, 4, 5 };

            // Act
            var triangle = new Triangle(sides);

            // Assert
            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void CreateTriangle_WithZeroParams_ArgumentException()
        {
            // Arrange
            var sides = new List<double> { 0, 0, 0 };

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sides));
        }

        [TestMethod]
        public void CreateTriangle_WithNegativeParams_ArgumentException()
        {
            // Arrange
            var sides = new List<double> { -1, -5, -10 };

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sides));
        }

        [TestMethod]
        public void CreateTriangle_WithUncorrectParams_ArgumentException()
        {
            // Arrange
            var sides = new List<double> { 1, 4, 10 };

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sides));
        }

        [TestMethod]
        public void CreateTriangle_WithFewerSides_ArgumentException()
        {
            // Arrange
            var sides = new List<double> { 3, 4 };

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sides));
        }

        [TestMethod]
        public void CreateTriangle_WithMoreSides_ArgumentException()
        {
            // Arrange
            var sides = new List<double> { 3, 4, 5, 10 };

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sides));
        }

        [TestMethod]
        public void IsTriangleRight_CorrectParam_True()
        {
            // Arrange
            var sides = new List<double> { 3, 4, 5 };

            // Act
            var triangle = new Triangle(sides);

            // Assert
            Assert.IsTrue(triangle.IsRightTriangle);
        }

        [TestMethod]
        public void IsTriangleRight_UncorrectParam_False()
        {
            // Arrange
            var sides = new List<double> { 3, 4, 4 };

            // Act
            var triangle = new Triangle(sides);

            // Assert
            Assert.IsFalse(triangle.IsRightTriangle);
        }

        [TestMethod]
        public void Area_CorrectParam_CorrectResult()
        {
            // Arrange
            var sides = new List<double> { 4, 4, 4 };
            var expected = 6.9282;

            // Act
            var triangle = new Triangle(sides);
            var actual = triangle.GetArea();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
