using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KarateChop;

namespace KarateTest
{
    [TestClass]
    public class KarateTest
    {
        [TestMethod]
        public void TargetNotFound_EmptyArray()
        {
            var karate = new Karate();

            var result = karate.Chop(3, new int[]{ });

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TargetNotFound_SingleElementArray()
        {
            var karate = new Karate();

            var result = karate.Chop(3, new int[] { 1 });

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TargetFoundAtIndex0_SingleElementArray()
        {
            var karate = new Karate();

            var result = karate.Chop(1, new int[] { 1 });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TargetFoundAtIndex0_ThreeElementArray()
        {
            var karate = new Karate();

            var result = karate.Chop(1, new int[] { 1, 3, 5 });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TargetFoundAtIndex1_ThreeElementArray()
        {
            var karate = new Karate();

            var result = karate.Chop(3, new int[] { 1, 3, 5 });

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TargetFoundAtIndex2_ThreeElementArray()
        {
            var karate = new Karate();

            var result = karate.Chop(5, new int[] { 1, 3, 5 });

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TargetNotFound_ThreeElementArray()
        {
            var karate = new Karate();

            var result = karate.Chop(0, new int[] { 1, 3, 5 });

            Assert.AreEqual(-1, result);
        }
    }
}
