using figAreaCalc;
using figAreaCalc.Clases;
using NUnit.Framework;

namespace figLibTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleTest()
        {
            Circle circle = new Circle { Radius= 5.642 };
            Assert.AreEqual(100, AreaCalc.GetArea(circle),0.009);
        }

        [Test]
        public void TriangleTest()
        {
            Triangle triangle = new Triangle(3,4,5);
            Assert.AreEqual(6, AreaCalc.GetArea(triangle), 0.009);
        }

    }
}