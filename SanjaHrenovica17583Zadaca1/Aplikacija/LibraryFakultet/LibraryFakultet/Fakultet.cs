using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using DBManager;

namespace FakultetLibrary
{
    [Serializable()]
    public class Fakultet
    {
        delegate int ProcessDelegate();
        // ProcessDelegate del1;    
        private string naziv, mjestoFakulteta;
        [XmlArrayItem("Master", typeof(Master))]
        [XmlArray("Studenti")]
       public System.Collections.Generic.List<Bachelor> Studenti;
        public System.Collections.Generic.List<Predmeti> Predmeti;
        [XmlArrayItem("NastavnoOsoblje", typeof(NastavnoOsoblje))]
        [XmlArrayItem("NenstavnoOsoblje", typeof(NenastavnoOsoblje))]
        [XmlArrayItem("PrivremeniUposlenici", typeof(PrivremeniUposlenici))]
        [XmlArrayItem("StalniUposlenici", typeof(StalniUposleni))]
        [XmlArray("Uposlenici")]
        public System.Collections.Generic.List<Osoba> Uposleni;
        Dbmanager dbmanager;

        public Fakultet(string ime, string mj)
        {
            Naziv = ime;
            MjestoFakulteta = mj;
            Studenti = new System.Collections.Generic.List<Bachelor>();
            Predmeti = new System.Collections.Generic.List<Predmeti>();
            Uposleni = new System.Collections.Generic.List<Osoba>();
            dbmanager = new Dbmanager();

        }
        public string DajNaziv(Fakultet f)
        {
            return f.Naziv;
        }
        public string DajMjesto(Fakultet f) {
            return f.MjestoFakulteta;
        }


        public void RegistrujStudenta(string ime, string prezime, DateTime datum, string jmbg, DateTime dpzo, string ki, string kp)
        {
            Boolean postoji = false;
            foreach (Bachelor b in Studenti) {
                if (b.DajMaticniBroj() == jmbg) {
                    postoji = true;
                    break;
                }
            }
            if (postoji == false)
            {
                Studenti.Add(new Bachelor(ime, prezime, datum, jmbg, dpzo, ki, kp));
                //dbmanager.dodajBachelorStudenta(ime, prezime, datum, jmbg, dpzo, ki, kp);
            }
           
        }
        public void RegistrujStudenta(string ime, string prezime, DateTime datum, string jmbg, DateTime dpzo, int i, string mjesto, string ki, string kp)
        {
            Master m = new Master(ime, prezime, datum, jmbg, dpzo, i, mjesto, ki, kp);
            if (mjesto != MjestoFakulteta) m.NapraviNoviIndex();
            Studenti.Add(m);

        }
        public void RegistrujStudenta(Bachelor b) {
            Studenti.Add(b);
                }
        public void RegistrujStudenta(Master m) {

            if (m.dajMjesto().Equals(MjestoFakulteta,StringComparison.Ordinal)) Studenti.Add(m);
            else {
                 m.NapraviNoviIndex();
                 Studenti.Add(m);
            }

        }
        public void ucitajUdatoteku( string datoteka)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Bachelor>));
            FileStream fs = new FileStream(datoteka, FileMode.Create);
            xs.Serialize(fs, Studenti);
            fs.Close();
 
        }
        public void ucitajIzdatoteke( string datoteka)
        {
            XmlSerializer deserijalizacija = new XmlSerializer(typeof(List<Bachelor>));
            FileStream lcitac = new FileStream(datoteka, FileMode.Open);
            Studenti = (List<Bachelor>)deserijalizacija.Deserialize(lcitac);
            lcitac.Close();

        }

        public int DajVelicinuListeStudenata()
        {
            return Studenti.Count();
        }
        public void BrisiStudetnta(string ind)
        {
           
            for (int i = 0; i < Studenti.Count(); i++)
            {
                if (Studenti[i].DajBrojIndexa() == ind) Studenti.Remove(Studenti[i]);
            }

        }
        public Osoba dajUposlenog (){ return Uposleni[Uposleni.Count() - 1]; }
        public List<Bachelor> dajListuStudenata()
        {
            return Studenti;
        }
        public void RegistrujPredmet(string naziv, int bv, int bp, int bs, int be, string o, string studij)
        {
            Predmeti.Add(new Predmeti(naziv, bv, bp, bs, be, o, studij));
           // dbmanager.dodajPredmet(naziv, bv, bp, bs, be, o, studij);
        }
        public void RegistrujPredmet(Predmeti p) {
            Predmeti.Add(p);
          
        }
        public void BrisiPredmet(string naziv) {

            if (Predmeti.Count() == 0) throw new SystemException("Trenutno nema registrovanih predmeta");
            for (int i = 0; i < Predmeti.Count(); i++)
            {
                if (Predmeti[i].DajNazivPredmeta() == naziv) Predmeti.Remove(Predmeti[i]);
            }
        }
        public List<Predmeti> PretraziPredmete(string im)
        {
            List<Predmeti> vrati = Predmeti.FindAll(x => x.Naziv == im);
            return vrati;
        }
        public List<Predmeti> PretraziPredmete(int s)
        {
            List<Predmeti> vrati = new List<Predmeti>();
            foreach (Predmeti p in Predmeti)
            {
                if (p.dajSifruPredmeta() == s) vrati.Add(p);
            }
            return vrati;
        }
        public List<string> PretraziSve(string s)
        {
            List<string> vrati = new List<string>();
            Parallel.ForEach(Predmeti, p => {
                if (p.DajNazivPredmeta().Contains(s)) vrati.Add(p.DajNazivPredmeta());
                Parallel.ForEach(Uposleni, n =>
                {
                    if (n.dajPrezime().Contains(s)) vrati.Add(n.dajPrezime());
                    if (n.DajIme().Contains(s)) vrati.Add(n.DajIme());

                });

            });
           
            Parallel.ForEach(Studenti, b => {
                if (b.dajPrezime().Contains(s)) vrati.Add(b.dajPrezime());
                if (b.DajIme().Contains(s)) vrati.Add(b.DajIme());
            });
            Parallel.ForEach(Uposleni, o => {
                if (o.dajPrezime().Contains(s)) vrati.Add(o.dajPrezime());
                if (o.DajIme().Contains(s)) vrati.Add(o.DajIme());
            });
                
            
            return vrati;
        }

        public void RegistrujUposlenogNenastavnoO(string ime, string prezime, DateTime datRodj, string maticni, string poz, string ss, string t, decimal plata)
        {
            bool postoji=false;
            foreach (Osoba o in Uposleni) {
                if (o.DajMaticniBroj() == maticni) { postoji = true; break; }
            }
            if (!postoji) {
                Uposleni.Add(new NenastavnoOsoblje(ime, prezime, datRodj, maticni, poz, ss, t, plata));
                
            }
        }
        public void RegistrujUposlenogNenastavno(NenastavnoOsoblje no) {
            bool postoji = false;
            foreach (Osoba o in Uposleni)
            {
                if (o.DajMaticniBroj() == no.DajMaticniBroj()) { postoji = true; break; }
            }
            if (!postoji)  Uposleni.Add(no);
        }
        public void RegistrujUposlenogNastavnoO(string ime, string prezime, DateTime datRodj, string maticni, string poz, string ss, string t, decimal plata, string kime, string loz)
        {
            bool postoji = false;
            foreach (Osoba o in Uposleni)
            {
                if (o.DajMaticniBroj() == maticni) { postoji = true; break; }
            }
            if (postoji==false) {
                Uposleni.Add(new NastavnoOsoblje(ime, prezime, datRodj, maticni, poz, ss, t, plata, kime, loz));
                //dbmanager.dodajNastavnika(ime, prezime, datRodj, maticni, poz, ss, t, plata, kime, loz);
            }
        }
        public void RegistrujUposlenogNastavnoO(NastavnoOsoblje no) {

            bool postoji = false;
            foreach (Osoba o in Uposleni)
            {
                if (o.DajMaticniBroj() == no.DajMaticniBroj()) { postoji = true; break; }
            }
            if (!postoji) Uposleni.Add(no);
        }

        public void RegistrujUposlenogPrivremeno(string ime, string prezime, DateTime datRodj, string maticni, string poz, string ss, string t, decimal plata, DateTime dp, DateTime di)

        {
            bool postoji = false;
            foreach (Osoba o in Uposleni)
            {
                if (o.DajMaticniBroj() == maticni) { postoji = true; break; }
            }
            if (!postoji) Uposleni.Add(new PrivremeniUposlenici(ime, prezime, datRodj, maticni, poz, ss, t, plata, dp, di));
        }
        public void RegistrujUposlenogPrivremeno(PrivremeniUposlenici pu)
        {
            bool postoji = false;
            foreach (Osoba o in Uposleni)
            {
                if (o.DajMaticniBroj() == pu.DajMaticniBroj()) { postoji = true; break; }
            }
            if (!postoji) Uposleni.Add(pu);
        }
        public void BrisiUposlenog(string ime)
        {
            for (int i = 0; i < Uposleni.Count(); i++)
            {
                if (Uposleni[i].DajIme() == ime) Uposleni.Remove(Uposleni[i]);
            }
        }
        public void BrisiUposlenog(int sifra)
        {
            for (int i = 0; i < Uposleni.Count(); i++)
            {

                StalniUposleni su = Uposleni[i] as StalniUposleni;
                if (su is StalniUposleni && su.DajSifruUposlenika() == sifra)
                {
                    Uposleni.Remove(su);
                }
                else continue;

            }
        }
        public List<Bachelor> PretraziStudente(string im)
        {
            List<Bachelor> vrati = Studenti.FindAll(x => x.Ime == im);
            return vrati;
        }
        public List<Bachelor> PretraziStudente(int ind)
        {
            List<Bachelor> vrati = Studenti.FindAll(x => x.DajBrojIndexa() == ind.ToString());
            return vrati;
        }
        public List<Osoba> PretraziUposlene(string im)
        {
            List<Osoba> vrati = Uposleni.FindAll(x => x.Ime == im);
            return vrati;
        }
        public List<StalniUposleni> PretraziUposlene(int sifra)
        {
            List<StalniUposleni> UposleniKojeVracam = new List<StalniUposleni>();
            for (int i = 0; i < Uposleni.Count(); i++)
            {

                StalniUposleni su = Uposleni[i] as StalniUposleni;
                if (su is StalniUposleni && su.DajSifruUposlenika() == sifra)
                {
                    UposleniKojeVracam.Add(su);
                }
                else continue;

            }
            return UposleniKojeVracam;
        }

        public int BrojStudenata() { return Studenti.Count(); }
        public int BrojPredmeta() { return Predmeti.Count(); }
        public int BrojUposlenih() { return Uposleni.Count(); }

        public void NovaPlata(int sifra)
        {
            int povecaj = 0;
            foreach (Predmeti i in Predmeti)
            {
                List<NastavnoOsoblje> listaPnaPredmetu = new List<NastavnoOsoblje>();
                listaPnaPredmetu = i.Ansambl().FindAll(x => x.DajSifruUposlenika() == sifra);
                if (listaPnaPredmetu.Count() != 0) povecaj++;
                foreach (NastavnoOsoblje no in listaPnaPredmetu)
                {
                    no.ObracunPlate(povecaj);
                }
            }

        }
        public int SifraUposlenika() {
            StalniUposleni su = Uposleni[Uposleni.Count() - 1] as StalniUposleni;
            return su.DajSifruUposlenika();
        }
        public string BrojIndexa()
        {
            return Studenti[Studenti.Count() - 1].DajBrojIndexa();
        }
        public int SifraPredmeta()
        {
            return Predmeti[Predmeti.Count() - 1].dajSifruPredmeta();
        }
        public Bachelor dajStudenta()
        {
            return Studenti[Studenti.Count() - 1];
        }
        public int UkupnoOsoba()
        {
            ProcessDelegate delS;
            delS = new ProcessDelegate(BrojStudenata);
            ProcessDelegate delU = new ProcessDelegate(BrojUposlenih);
            int st = delS();
            int up = delU();
            int zbir = st + up;
            return zbir;
        }
        public decimal ProsjekPlate()
        {
            if (Uposleni.Count() == 0) throw new ArgumentException("Trenutno nema uposlenih");

            decimal suma = 0m;

            foreach (Osoba su in Uposleni)
            {
                suma += Decimal.Parse( su.dajIznosPlate());
            }
            decimal prosjek = suma / Uposleni.Count();
            return prosjek;
        }

        public void DodajUAnsamblPredmeta(string predU)
        {
            List<Predmeti> pp = new List<Predmeti>();
            pp = Predmeti.FindAll(x => x.DajNazivPredmeta() == predU);
            if (pp.Count() == 0) throw new ArgumentException("Izabrani predmet ne postoji");
            else {
                foreach (Predmeti p in Predmeti)
                {
                    NastavnoOsoblje no = Uposleni[Uposleni.Count() - 1] as NastavnoOsoblje;
                    if (p.DajNazivPredmeta() == predU) p.DodajUAnsambl(no);
                }

            }
        }
        public bool ProvjeraPrijave(string ime, string pw)
        {
            bool jeste = false;
            foreach (Bachelor b in Studenti)
            {
                if (b.dajKorisnickoIme() == ime && b.dajLozinku() == pw) { jeste = true; break; }
            }
            foreach (Osoba o in Uposleni)
            {
                if (o.dajKorisnickoIme() == ime && o.dajLozinku() == pw) { jeste = true; break; }
            }
            return jeste;
        }
        public string kojiProzor(string ime, string pw)
        {
            string vrati=" ";
            foreach (Bachelor b in Studenti)
            {
                if (b.dajKorisnickoIme() == ime && b.dajLozinku() == pw) { vrati="student"; break; }
            }
            foreach (Osoba o in Uposleni)
            {
                if (o.dajKorisnickoIme() == ime && o.dajLozinku() == pw) { vrati = "profesor"; break; }
            }
            
            return vrati;
        }
        public void dodajuListuStudenata(Bachelor b)
        {
            Studenti.Add( b);
        }
        public List<Osoba> dajListuUposlenih()
        {
            return Uposleni;
        }
        public List<Predmeti> dajListuPredmeta()
        {
            return Predmeti;
        }
        public int velicinaPredmeti() { return Predmeti.Count(); }
        public int velicinaUposleni() { return Uposleni.Count(); }
        public Predmeti dajPredmet() { return Predmeti[Predmeti.Count() - 1]; }
        public Predmeti dajPredmet(string ime)
        {
            Predmeti vrati = new Predmeti();
            
                foreach (Predmeti p in Predmeti) {
                    foreach (NastavnoOsoblje no in p.Ansambl()) if (no.dajKorisnickoIme() == ime) vrati = p;
                        }
            
            return vrati ;
        }
        public void registrujNastavnoOsoblje(NastavnoOsoblje no)
        {
            Uposleni.Add(no);
        }
        public List<NastavnoOsoblje> dajNastavniAnsambl(Predmeti p)
        {
            List<NastavnoOsoblje> vrati = new List<NastavnoOsoblje>();
            foreach(Predmeti pr in Predmeti)
            {
                if (p.DajNazivPredmeta() == pr.DajNazivPredmeta()) vrati= pr.Ansambl();
            }
            return vrati;
        }
        public List<Predmeti> spisakPPredmeta(string korIme)
        {
            List<Predmeti> vrati = new List<Predmeti>(); 
            foreach(Bachelor b in Studenti)
            {
                if (b.dajKorisnickoIme() == korIme) vrati = b.DajSpisakPPredmeta();
            }
            return vrati;
        }
        public void dodajUSpisakPredmeta(Predmeti p, string korIme)
        {
            foreach (Bachelor b in Studenti)
            {
                if (b.dajKorisnickoIme() == korIme) b.DodajAktivniPredmet(p);
            }
        }
        public void ukloniPredmet(string p, string korIme)
        {
            foreach (Bachelor b in Studenti)
            {
                if (b.dajKorisnickoIme() == korIme) b.ukloniPredmet(p);
            }
        }
        public List<Predmeti> aktivniPredmeti(string korIme)
        {
            List<Predmeti> vrati = new List<Predmeti>();
            foreach (Bachelor b in Studenti)
            {
                if (b.dajKorisnickoIme() == korIme) vrati = b.dajAktivnePredmete();
            }
            return vrati;
        }

        public string dajPw() { return Studenti[Studenti.Count()-1].dajLozinku(); }
        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

       public string MjestoFakulteta
        {
            get
            {
                return mjestoFakulteta;
            }

            set
            {
                mjestoFakulteta = value;
            }
        }
    }
}
