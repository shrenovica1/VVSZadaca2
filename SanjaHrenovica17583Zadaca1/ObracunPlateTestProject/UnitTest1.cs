using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakultetLibrary;
using System.Globalization;

namespace ObracunPlateTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Fakultet faks;
        DateTime dr;
        DateTime dt;
        DateTime dp;
        [TestInitialize]
        public void setUp()
        {
             faks = new Fakultet("etf", "Sarajevo");
             dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
             dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
             dp = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }
        [TestMethod]
        public void TestObracunPlateNastavnoOsoblje()
        {
           
            NastavnoOsoblje no = new NastavnoOsoblje("ime", "prezime", dr, "0611996175021", "poz", "strucnjak", "profesor", Convert.ToDecimal(200.00), "p1", "ploz");
            no.ObracunPlate(10);
            String obracun = no.dajIznosPlate();
            
            Assert.AreEqual(obracun, "203.20");
        }
        [TestMethod]
        public void TestObracunPlateNenastavnoOsoblje()
        {
           
            NenastavnoOsoblje no = new NenastavnoOsoblje("ime", "prezime", dr, "0611996175021", "poz", "strucnjak", "portir", Convert.ToDecimal(200.00));
            faks.RegistrujUposlenogNenastavno(no);
            decimal obracun = no.DajPlatu();
            decimal test = 264.00m;
            Assert.AreEqual(test, obracun);
        }
        [TestMethod]
        public void TestObracunPlateStalniUposlenici()
        {
            
            StalniUposleni su = new StalniUposleni("ime", "prezime", dr, "0611996175021", "poz", "strucnjak", "portir", Convert.ToDecimal(200.00));
            decimal obracun = su.DajPlatu();
            decimal test = 200.00m;
            Assert.AreEqual(test, obracun);
        }
        [TestMethod]
        public void TestObracunPlatePrivremeniUposlenici()
        {
          
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
          

            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
          
            decimal obracun = pu.DajPlatu();
            decimal test = 200.00m;
            Assert.AreEqual(test, obracun);
        }
        [TestMethod]
        public void TestProsjekPlate(){
            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
            faks.RegistrujUposlenogPrivremeno(pu);
            NenastavnoOsoblje no = new NenastavnoOsoblje("ime", "prezime", dr, "0611996175021", "poz", "strucnjak", "portir", Convert.ToDecimal(200.00));
            faks.RegistrujUposlenogNenastavno(no);
            NastavnoOsoblje na = new NastavnoOsoblje("ime", "prezime", dr, "0611996175011", "poz", "strucnjak", "profesor", Convert.ToDecimal(200.00), "p1", "ploz");
            na.ObracunPlate(10);
            faks.RegistrujUposlenogNastavnoO(na);

            decimal prosjekPlate = faks.ProsjekPlate();
            decimal expected = 222.40m;

            Assert.AreEqual(expected, prosjekPlate);

        }
       

    }
}
