using KarateChop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KarateChopTest
{
    [TestClass]
    public class KarateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var karate = new Karate();

            var result = karate.Chop(3, new int[] { });

            Assert.AreEqual(-1, result);
        }
    }
}
