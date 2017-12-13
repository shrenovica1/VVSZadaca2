using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using FakultetLibrary;

namespace FirstUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      
            public void TestBachelorConstructor()
            {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            
                Bachelor bach = new Bachelor("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
                Assert.IsNotNull(bach);
            }
       

        [TestMethod]
        public void TestRegistracijaBachelor() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.RegistrujStudenta("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
            List<Bachelor> listaStudenata=faks.dajListuStudenata();

            CollectionAssert.AllItemsAreNotNull(listaStudenata);
        }
        [TestMethod]
        public void TestRegistracijaUposlenik()
        {
            
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.RegistrujUposlenogNastavnoO("ime", "prezime", dr, "0611996175021", "poz", "strucnjak", "profesor", Convert.ToDecimal(200.00), "p1", "ploz");
            NenastavnoOsoblje ne = new NenastavnoOsoblje("ime", "prezime", dr, "0611996175013", "poz", "strucnjak", "portir", Convert.ToDecimal(200.00));
            faks.RegistrujUposlenogNenastavno(ne);
            faks.RegistrujUposlenogNenastavno(ne);
            List<Osoba> uposlenici = faks.dajListuUposlenih();
          
            CollectionAssert.AllItemsAreUnique(uposlenici);
        }
        [TestMethod]
        public void TestRegistrujPredmet() {

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            
            Predmeti p= new Predmeti("matematika", 40, 12, 100, 5, "odg", "prva godina studija");
            faks.RegistrujPredmet(p);
            List<Predmeti> predmeti = faks.dajListuPredmeta();
            CollectionAssert.Contains(predmeti, p);

        }
        [TestMethod]
        public void TestRegistrujPrivremenogUposlenika (){
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dp = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2018", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
            faks.RegistrujUposlenogPrivremeno(pu);
            List<Osoba> uposlenici = faks.dajListuUposlenih();
            CollectionAssert.AllItemsAreInstancesOfType(uposlenici, typeof(PrivremeniUposlenici));
         
        }
        [TestMethod]
        public void TestMaticniBroj() {
            DateTime dp = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2018", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
            String testMaticnogBroja = "0611996";
            StringAssert.StartsWith(pu.DajMaticniBroj(), testMaticnogBroja);
        }
        [TestMethod]
        public void TestRegistracijaMaster() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.RegistrujStudenta("Sanja", "Hrenovica", dr, "0611996175013", dt,2,"Sarajevo", "shrenovica", "pass");
            List<Bachelor> listaStudenata = faks.dajListuStudenata();

            CollectionAssert.AllItemsAreInstancesOfType(listaStudenata, typeof(Master));
         //   CollectionAssert.AllItemsAreNotNull(listaStudenata);
        }
        [TestMethod]
        public void TestIndexMasterStudenta() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Master ma= new Master("Sanja", "Hrenovica", dr, "0611996175013", dt, 17583, "Sarajevo", "shrenovica", "pass");
            String index= ma.DajBrojIndexa();
            StringAssert.Contains(index, "/17583");
        }
        [TestMethod]
        public void TestIzbrisiStudenta() {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Master ma = new Master("Sanja", "Hrenovica", dr, "0611996175013", dt, 17583, "Sarajevo", "shrenovica", "pass");
            faks.RegistrujStudenta(ma);
            faks.BrisiStudetnta(ma.DajBrojIndexa());
            List<Bachelor> studenti = faks.dajListuStudenata();
            CollectionAssert.DoesNotContain(studenti, ma);
        }
        [TestMethod]
        public void TestDodajAktivniPredmet() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Bachelor bach = new Bachelor("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
            Predmeti p = new Predmeti("matematika", 40, 12, 100, 5, "odg", "prva godina studija");
            bach.DodajAktivniPredmet(p);
            List<Predmeti> predmetiTest = bach.dajAktivnePredmete();
            CollectionAssert.Contains(predmetiTest, p);
            

        }
        [TestMethod]
        public void TestListaPredmeta() {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            Predmeti p = new Predmeti("matematika", 40, 12, 100, 5, "odg", "prva godina studija");
            Predmeti p1 = new Predmeti("matematika2", 40, 12, 100, 5, "odg", "prva godina studija");
            Predmeti p2 = new Predmeti("Logicki dizajn", 30, 12, 50, 5, "odg", "druga godina studija");
            Predmeti p3 = new Predmeti("Diskretna matematika", 30, 12, 50, 5, "odg", "druga godina studija");
            
            List<Predmeti> predmetiTest = new List<Predmeti>();
            predmetiTest.Add(p); predmetiTest.Add(p1); predmetiTest.Add(p2);
            faks.RegistrujPredmet(p);
            faks.RegistrujPredmet(p1);
            faks.RegistrujPredmet(p2);
            faks.RegistrujPredmet("Diskretna matematika", 30, 12, 50, 5, "odg", "druga godina studija");
            List<Predmeti> fakultetskiPredmeti = faks.dajListuPredmeta();
            CollectionAssert.IsSubsetOf(predmetiTest,fakultetskiPredmeti);
        }
        [TestMethod]
        public void TestPretragaStudenata() {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Master ma = new Master("Sanja", "Hrenovica", dr, "0611996175013", dt, 17583, "Sarajevo", "shrenovica", "pass");
            Bachelor ba= new Bachelor("Selma", "Hrenovica", dr, "0611996175021", dt, "shrenovica2", "pass");
            faks.RegistrujStudenta(ba);
            faks.RegistrujStudenta(ma);
            List<Bachelor> listaTest = faks.PretraziStudente(ma.DajBrojIndexa());
            CollectionAssert.DoesNotContain(listaTest, ba);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ime ne moze biti prazno")]
        public void TestExceptionPraznoIme()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Bachelor ba = new Bachelor("", "Hrenovica", dr, "0611996175021", dt, "shrenovica2", "pass");


        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "JMBG mora imati 13 znamenki")]
        public void TestExceptionDuzinaJMBG() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Bachelor ba = new Bachelor("Selma", "Hrenovica", dr, "061199617502", dt, "shrenovica2", "pass");
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Trenutno nema uposlenih")]
        public void TestExceptionProsjekPlate() {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.ProsjekPlate();

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Izabrani predmet ne postoji")]
        public void TestExceptionDodajAnsamblPredmeta()
        {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.DodajUAnsamblPredmeta("Biologija");

        }
        [TestMethod]
        public void TestDatumiUgovoraPrivremeniRadnik() {
            DateTime dp = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2018", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
            Assert.AreNotEqual(dp.ToString(), dt.ToString());
        }
        [TestMethod]
        public void TestIzbrisiUposlenika() {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            NastavnoOsoblje no = new NastavnoOsoblje("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00),"nn","lozinkann");
            faks.RegistrujUposlenogNastavnoO(no);
            faks.RegistrujUposlenogNastavnoO("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), "nn","lozinkann");
            faks.BrisiUposlenog(no.DajIme());
            List<Osoba> listaTest = faks.dajListuUposlenih();
            CollectionAssert.AllItemsAreNotNull(listaTest);
        }
        [TestMethod]
        public void TestPretraziUposlenePoSifri() {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            NastavnoOsoblje no = new NastavnoOsoblje("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), "nn", "lozinkann");
            faks.RegistrujUposlenogNastavnoO(no);
            List<StalniUposleni> lista=faks.PretraziUposlene(no.DajSifruUposlenika());
            CollectionAssert.Contains(lista, no);
            
            
        }
        [TestMethod]
        public void TestToStringNastavnOsoblje() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            NastavnoOsoblje no = new NastavnoOsoblje("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), "nn", "lozinkann");
            StringAssert.Equals(no.ToString(), "Ime i prezime: osoba prezime \n Pozicija: pozicija1");
           // "Ime i prezime: " + Ime + " " + Prezime + "\n" + " Pozicija: " + Pozicija;
        }
        [TestMethod]
        public void TestDuzinaIndexa()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Bachelor ba = new Bachelor("Selma", "Hrenovica", dr, "0611996175021", dt, "shrenovica2", "pass");
            String pattern = @"^([0-9]){5}$";
            Regex reg = new Regex(pattern);
            StringAssert.Matches(ba.DajBrojIndexa(),reg);
            
        }
        [TestMethod]
        public void TestListaStudenata()
        {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Bachelor ba = new Bachelor("Selma", "Hrenovica", dr, "0611996175021", dt, "shrenovica2", "pass");
            faks.RegistrujStudenta("Sanja", "Hrenovica", dr, "0611996175013", dt, 2, "Sarajevo", "shrenovica", "pass");
            faks.dodajuListuStudenata(ba);
            List<Bachelor> listaTest = faks.dajListuStudenata();
            Assert.IsTrue(listaTest.Count == 2);
        }

        [TestMethod]
        public void TestNasljedjivanjaStudenta()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Master ma = new Master("Sanja", "Hrenovica", dr, "0611996175013", dt, 2, "Sarajevo", "shrenovica", "pass");
            Assert.IsInstanceOfType(ma, typeof(Osoba));
        }

        [TestMethod]
        public void TestDodajuAnsamblPredemeta()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Master ma = new Master("Sanja", "Hrenovica", dr, "0611996175013", dt, 2, "Sarajevo", "shrenovica", "pass");
            Assert.IsInstanceOfType(ma, typeof(Osoba));
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException), "Trenutno nema registrovanih predmeta")]
        public void TestIzbrisiPredmet() {
            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.BrisiPredmet("predmet");
        }
        [TestMethod]
        public void TestPretraziUposlene() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dp = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2018", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
            faks.RegistrujUposlenogPrivremeno(pu);
            List<StalniUposleni> listaTest = faks.PretraziUposlene(12122);
            Assert.IsTrue(listaTest.Count == 0);
        }
        [TestMethod]
        public void TestUkupnoOsoba() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dp = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2018", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
            faks.RegistrujUposlenogPrivremeno(pu);
            faks.RegistrujUposlenogPrivremeno(pu);
            Bachelor ba = new Bachelor("Selma", "Hrenovica", dr, "0611996175021", dp, "shrenovica2", "pass");
            faks.RegistrujStudenta("Sanja", "Hrenovica", dr, "0611996175013", dp, 2, "Sarajevo", "shrenovica", "pass");
              Assert.AreEqual(2, faks.UkupnoOsoba());

        }
        [TestMethod]
        public void TestSirfaRadnika() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dp = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2018", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            String patternSifraStanli = @"^([0-9]){3}$";
            Regex regStalni = new Regex(patternSifraStanli);

            String patternSifraPrivremeni = @"^([0-9]){5}$";
            Regex regPrivremeni = new Regex(patternSifraPrivremeni);

            PrivremeniUposlenici pu = new PrivremeniUposlenici("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), dp, dt);
            NastavnoOsoblje no = new NastavnoOsoblje("osoba", "prezime", dr, "0611996175013", "pozicija1", "srednja strucna sprema", "titula1", Convert.ToDecimal(200.00), "nn", "lozinkann");
            NenastavnoOsoblje ne = new NenastavnoOsoblje("ime", "prezime", dr, "0611996175021", "poz", "strucnjak", "portir", Convert.ToDecimal(200.00));

            StringAssert.Matches(no.dajSifru(), regStalni,"Sifra za nastavno osoblje");
            StringAssert.DoesNotMatch(pu.dajSifru(), regStalni, "Sifra privremenog uposlenika");
            StringAssert.DoesNotMatch(ne.dajSifru(), regPrivremeni, "Sifra nenastavno osblje");
        }
     
        [TestMethod]
        public void TestDajPodatkeZadnjegStudenta()
        {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.RegistrujStudenta("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
            Master ma = new Master("Selma", "Hrenovica", dr, "0611996175021", dt, 17583, "Sarajevo", "shrenovica2", "pass2123");
            faks.RegistrujStudenta(ma);

            Assert.AreSame(faks.dajStudenta(), ma, "Test zadnjeg studenta u listi");
            Assert.AreEqual(faks.BrojIndexa(), ma.DajBrojIndexa(), "Test broj indexa zadnjeg studenta u listi");

        }
        [TestMethod]
        public void TestProzora() {
            DateTime dr = DateTime.ParseExact("06.11.1996", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact("24.01.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Fakultet faks = new Fakultet("etf", "Sarajevo");
            faks.RegistrujStudenta("Sanja", "Hrenovica", dr, "0611996175013", dt, "shrenovica", "pass");
            Master ma = new Master("Selma", "Hrenovica", dr, "0611996175021", dt, 17583, "Sarajevo", "shrenovica2", "pass2123");
            faks.RegistrujStudenta(ma);
            faks.RegistrujUposlenogNastavnoO("ime", "prezime", dr, "0611996175021", "poz", "strucnjak", "profesor", Convert.ToDecimal(200.00), "p1", "ploz");

            Assert.AreEqual("profesor", faks.kojiProzor("p1", "ploz"), "Test da se otvori prozor za profesora");
            Assert.AreNotEqual("profesor", faks.kojiProzor("shrenovica", "pass"), "Test da se otvori prozor za studenta - notequal1");
            Assert.AreNotEqual(" ", faks.kojiProzor("shrenovica2", "pass2123"), "Test da se otvori prozor za studenta - notequal2");
            Assert.AreEqual("student", faks.kojiProzor("shrenovica2", "pass2123"), "Test da se otvori prozor za studenta -equal");
            Assert.AreEqual(" ", faks.kojiProzor("shrenov", "pass2123"), "Test nije ni student ni profesor");

        }
       






    }
}
