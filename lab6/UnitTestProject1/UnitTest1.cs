using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia_0()
        {
            silnia LL1 = new silnia();
            Assert.AreEqual(LL1.oblicz(0), 1);
        }


        [TestMethod]
        public void Silnia_1()
        {
            silnia LL1 = new silnia();
            Assert.AreEqual(LL1.oblicz(1), 1);
        }

        [TestMethod]
        public void Silnia_5()
        {
            silnia LL1 = new silnia();
            Assert.AreEqual(LL1.oblicz(5), 120);
        }



    }
}
