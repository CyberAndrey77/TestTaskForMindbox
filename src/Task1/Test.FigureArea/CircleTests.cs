using FigureArea;
namespace Test.FigureArea
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Constructor_WithoutParams_CreateObject()
        {
            // Arrange

            // Act
            var circle = new Circle();

            // Assert
            Assert.IsNotNull(circle);
        }

        [TestMethod]
        public void Constructor_WithoutParams_RadiusIsOne()
        {
            // Arrange
            var expected = 1;

            // Act
            var circle = new Circle();
            var actual = circle.Radius;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Contructor_WithCorrectParam_CurretRadius()
        {
            // Arrange
            var expected = 10;
            var circle = new Circle(10);

            // Act
            var actual = circle.Radius;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Contructor_WithZeroParam_ArgumentException()
        {
            // Arrange

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
        }

        [TestMethod]
        public void Contructor_WithNegativeParam_ArgumentException()
        {
            // Arrange

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(-10));
        }

        [TestMethod]
        public void ChangeRadius_WithCorrectParam_CurretChange()
        {
            // Arrange
            var expected = 10;
            var circle = new Circle();

            // Act
            circle.Radius = 10;
            var actual = circle.Radius;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeRadius_WithZeroParam_ArgumentException()
        {
            // Arrange
            var circle = new Circle();

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => circle.Radius = 0);
        }

        [TestMethod]
        public void ChangeRadius_WithNegativeParam_ArgumentException()
        {
            // Arrange
            var circle = new Circle();

            // Act

            // Assert
            Assert.ThrowsException<ArgumentException>(() => circle.Radius = -10);
        }

        [TestMethod]
        public void GetArea_CurrectArea()
        {
            // Arrange
            var circle = new Circle(10);
            var expected = 314.1593;

            // Act
            var actual = circle.GetArea();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}