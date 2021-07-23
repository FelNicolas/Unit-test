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
        public void Test1()
        {
            var result = target.Add(1,2);
            Assert.AreEqual(4, result, "It is wrong");
        }
    }
}