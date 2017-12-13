using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aplikacija;
using FakultetLibrary;
using System.Globalization;
using FakultetLibrary;

namespace DataDrivenUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        static Fakultet faks;
        private TestContext testContextInstance;
        public TestContext TestContext { get { return testContextInstance; } set { testContextInstance = value; } }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Podaci.csv", "Podaci#csv", DataAccessMethod.Sequential), DeploymentItem("Podaci.csv"), TestMethod]
        public void TestCSVDatoteka()
        {
           // DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            //DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Bachelor bach = new Bachelor(Convert.ToString(TestContext.DataRow["Ime"]), Convert.ToString(TestContext.DataRow["Prezime"]), DateTime.ParseExact(Convert.ToString(TestContext.DataRow["DatumRodjenja"]), "dd.MM.yyyy", CultureInfo.InvariantCulture), Convert.ToString(TestContext.DataRow["MaticniBroj"]), DateTime.ParseExact(Convert.ToString(TestContext.DataRow["DatumZavrsetka"]), "dd.MM.yyyy", CultureInfo.InvariantCulture), Convert.ToString(TestContext.DataRow["KorisnickoIme"]), Convert.ToString(TestContext.DataRow["Lozinka"]));
            Assert.IsTrue(bach.DajIme() == Convert.ToString(TestContext.DataRow["Ime"]));
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Podaci.xml", "student", DataAccessMethod.Sequential), DeploymentItem("Podaci.xml"), TestMethod]
        public void TestXMLDatoteka()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Bachelor bach = new Bachelor(Convert.ToString(TestContext.DataRow["Ime"]), Convert.ToString(TestContext.DataRow["Prezime"]), DateTime.ParseExact(Convert.ToString(TestContext.DataRow["DatumRodjenja"]), "dd.MM.yyyy", CultureInfo.InvariantCulture), Convert.ToString(TestContext.DataRow["MaticniBroj"]), DateTime.ParseExact(Convert.ToString(TestContext.DataRow["DatumZavrsetka"]), "dd.MM.yyyy", CultureInfo.InvariantCulture), Convert.ToString(TestContext.DataRow["KorisnickoIme"]), Convert.ToString(TestContext.DataRow["Lozinka"]));
            Assert.IsTrue(bach.DajIme() == Convert.ToString(TestContext.DataRow["Ime"]));
        }


    }
}
