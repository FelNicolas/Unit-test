using ClassLibrary1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        public Class1 target;
        /// <summary>
        /// It will run the setup first when you run a test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            target = new Class1();
        }

        [Test]
        [Category("test1")]
        [TestCase(1, 2, 3)]
        [TestCase(19, 3, 22)]
        [TestCase(5, 2, 7)]
        [TestCase(4, 2, 7)]
        public void Test1(int a, int b, int expectedResult)
        {
            var result = target.Add(a, b);
            Assert.AreEqual(expectedResult, result, "It is wrong");
            // With Package
            // More readable
            //result.Should().Be(4);
        }

        [Test]
        [Category("Test2")]
        public void Test2()
        {
            Assert.AreEqual();
        }

    }
}