using AreaLibrary;

namespace Tests
{
    public class CircleTests
    {
        // Accuracy
        double accuracy = 0.01;

        // Positive Circle Tests
        [TestCase(4, 50.26)]
        [TestCase(10, 314.15)]
        [TestCase(5, 78.54)]
        [TestCase(1, 3.14)]
        [TestCase(2.5, 19.625)]
        [Test]
        public void CirclePositiveTests(double R, double exp)
        {
            Circle circleSample = new Circle(R);
            Assert.AreEqual(circleSample.CalculatingSquare(), exp, accuracy);
        }

        // Negative Circle Testss
        [TestCase(0)]
        [TestCase(-1)]
        [Test]
        public void CircleNegativeTests(double R)
        {
            Assert.Throws<ArgumentException>(() => new Circle(R));

        }
    }
}