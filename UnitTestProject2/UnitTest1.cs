using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPos()
        {
            Knihovnatrid.Class1 trida = new Knihovnatrid.Class1();
            string ocekavane = "Ahoj";
            Assert.AreEqual(ocekavane, trida.ToString());

        }

        [TestMethod]
        public void TestMethodNeg()
        {
            Knihovnatrid.Class1 trida = new Knihovnatrid.Class1();
            string ocekavane = "cAU";
            Assert.AreEqual(ocekavane, trida.ToString());

        }
        [TestMethod]
        public void TestMethodRPR()
        {
            Knihovnatrid.Class1 trida = new Knihovnatrid.Class1();
            string ocekavane = "ncwibefowbfweoRPRocbqwoebfoqwe";
            Assert.IsTrue(ocekavane.Contains(trida.RPR()));
        }
        [TestMethod]
        public void TestMethodRPRNeg()
        {
            Knihovnatrid.Class1 trida = new Knihovnatrid.Class1();
            string ocekavane = "ncwibefowbfweoRPocbqwoebfoqwe";
            Assert.IsTrue(ocekavane.Contains(trida.RPR()));
        }
        [TestMethod]
        public void TestMethodHeslo()
        {
            Knihovnatrid.Class1 trida = new Knihovnatrid.Class1();
            string heslo = "12345678";
            Assert.IsTrue(heslo.Length >= 8 && heslo.Length <= 20 && heslo != "");
        }
        [TestMethod]
        public void TestMethodHesloNeg()
        {
            Knihovnatrid.Class1 trida = new Knihovnatrid.Class1();
            string heslo = "";
            Assert.IsTrue(heslo.Length >= 8 && heslo.Length <= 20 && heslo != "");
        }
    }
}
