using FigureLib;

namespace FigureLibTests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void Circle_GetArea_ReturnsCorrectValue()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.AreEqual(Math.PI * 25, result);
        }

        [TestMethod]
        public void Triangle_GetArea_ReturnsCorrectValue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.GetArea();

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            // Arrange
            var triangle = new Triangle(1, 2, 3);

            // Act
            var result = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
