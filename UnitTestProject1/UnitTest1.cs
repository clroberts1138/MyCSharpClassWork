using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fundamentals;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dinosaur dino = new Dinosaur();
            string result = dino.Color;

            Assert.AreEqual("Green", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Dinosaur dino = new Dinosaur();
            dino.Size = 50;
            Assert.AreEqual(50, dino.Size);
        }
    }
}
