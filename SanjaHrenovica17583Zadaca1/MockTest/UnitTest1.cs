using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakultetLibrary;
using System.Globalization;
using System.Collections.Generic;

namespace MockTest
{
    [TestClass]
    public class UnitTest1
    {
        IStudentska istudentska;
        Studentska sluzba;
        Fakultet faks;

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }

        }

        [TestInitialize]
        public void setUp()
        {
            faks = new Fakultet("etf", "Sarajevo");
            istudentska = new MockStudentska(faks);
            sluzba = new Studentska(istudentska);
        }

        [TestMethod]
        public void TestDajPotvrdu()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Bachelor bach = new Bachelor("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
            faks.RegistrujStudenta(bach);
            istudentska = new MockStudentska(faks);
            StringAssert.Equals("Podnesite zahtjev za potvrdu", istudentska.dajPotvrdu(Convert.ToInt32(bach.DajBrojIndexa())));

        }

        [TestMethod]
        public void TestBrojStudenata()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Bachelor bach = new Bachelor("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
            faks.RegistrujStudenta(bach);
            istudentska = new MockStudentska(faks);
            Assert.IsTrue(istudentska.brojStudenata() == 1);

        }
        [TestMethod]
        public void TestPolozeniPredmeti()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Bachelor bach = new Bachelor("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
            faks.RegistrujStudenta(bach);
            Predmeti p = new Predmeti("Matematika", 20, 20, 100,5, "matematika1", "prva godina");
            Predmeti p1 = new Predmeti("Matematika2", 20, 20, 100, 5, "matematika2", "prva godina");
            bach.DodajPredmet(p);
            bach.DodajPredmet(p1);
            istudentska = new MockStudentska(faks);
            List<Predmeti> testList = istudentska.polozeniPredmeti(bach);
            CollectionAssert.Contains(testList, p);
            CollectionAssert.Contains(testList, p1);

        }
        [TestMethod]
        public void TestPrijaviIspit() {
            Predmeti p = new Predmeti("Matematika", 20, 20, 100, 5, "matematika1", "prva godina");
            istudentska = new MockStudentska(faks);
            istudentska.prijaviIspit(p);
            CollectionAssert.Contains(istudentska.prijavljeniIspiti(), p);
        }
    }
}
