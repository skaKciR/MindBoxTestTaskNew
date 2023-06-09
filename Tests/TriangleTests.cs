using AreaLibrary;

namespace Tests
{
    public class TriangleTests
    {
        // Accuracy
        double accuracy = 0.01;

        // Positive TriangleTests
        [TestCase(3, 4, 5, 6)]
        [TestCase(19, 12, 12, 69.64867191842211)]
        [TestCase(5, 5, 6, 12)]
        [TestCase(15, 13, 4, 24)]
        [TestCase(6, 7, 9, 20.97617696340303)]
        [TestCase(18, 18, 35, 73.72881051529313)]
        [TestCase(5.8, 4.2, 1.9, 2.515073)]
        [Test]
        public void TrianglePositiveTests(double a, double b, double c, double exp)
        {
            Triangle triangleSample = new Triangle(a, b, c);
            Assert.AreEqual(triangleSample.CalculatingSquare(), exp, accuracy);
        }

        // Negative Triangle Tests
        [TestCase(5, 2, 7)]
        [TestCase(14, 2, 8)]
        [TestCase(2, 14, 8)]
        [TestCase(0, 4, 5)]
        [TestCase(3, 0, 5)]
        [TestCase(3, 4, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 4, 5)]
        [TestCase(4, -1, 5)]
        [TestCase(4, 1, -5)]
        [TestCase(-4, -1, -5)]
        [TestCase(5.8, 4.2, 1.6)]
        [Test]
        public void TriangleNegativeTests(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        // Checking if Triangle is Right
        [TestCase(5, 4, 3, true)]
        [TestCase(3, 4, 5, true)]
        [TestCase(5, 12, 13, true)]
        [TestCase(6, 8, 10, true)]
        [Test]
        public void ChecikngRightTriangle(double a, double b, double c, bool exp)
        {
            Triangle triangleSample = new Triangle(a, b, c);
            Assert.AreEqual(triangleSample.IsRight(), exp);
        }

        // Checking if Triangle isn't Right
        [TestCase(6, 4, 3, false)]
        [TestCase(4, 5, 8, false)]
        [TestCase(4, 7, 5, false)]
        [TestCase(5, 12, 14, false)]
        [Test]
        public void ChecikngNotRightTriangle(double a, double b, double c, bool exp)
        {
            Triangle triangleSample = new Triangle(a, b, c);
            Assert.AreEqual(triangleSample.IsRight(), exp);
        }



    }
}