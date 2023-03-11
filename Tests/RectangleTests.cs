using AreaLibrary;

namespace Tests
{
    public class RectangleTests
    {
        // Accuracy
        double accuracy = 0.01;

        // Positive Rectangle Tests
        [TestCase(5, 8, 40)]
        [TestCase(9, 10, 90)]
        [TestCase(5.5, 4.5, 24.75)]
        [Test]
        public void RectanglePositiveTests(double a, double b, double exp)
        {
            Rectangle rectangleSample = new Rectangle(a, b);
            Assert.AreEqual(rectangleSample.CalculatingSquare(), exp, accuracy);
        }

        // Negative Rectangle Tests
        [TestCase(0, 5)]
        [TestCase(5, -1)]
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [Test]
        public void RectangleNegativeTests(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(a, b));

        }
    }
}