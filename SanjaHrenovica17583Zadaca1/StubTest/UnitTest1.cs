using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakultetLibrary;


namespace StubTest
{
    [TestClass]
    public class UnitTest1
    {
        ocjenaZadace ocjena;
        [TestInitialize]
        public void setUp()
        {
            ocjena = new ocjenaZadace(new DummyOcjenacs());
        }

        [TestMethod]
        public void TestBoduj()
        {
            int uradjeniZadaci = 10;
            decimal expected = 15m;
            Assert.IsTrue(expected==ocjena.boduj(uradjeniZadaci));
        }
        [TestMethod]
        public void TestdaLiJeOcjenjena()
        {
            Assert.IsTrue(ocjena.daLiJeOcjenjena());

        }
        [TestMethod]
        public void TestKomentara()
        {
            string expected = "Komentar: Primjer komentara";
            StringAssert.Equals(expected, ocjena.komentarNaZadacu());

        }




    }
}
