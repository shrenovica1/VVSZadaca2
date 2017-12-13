using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using Validacija17583;


namespace FakultetLibrary
{
    [Serializable]
    [XmlType(TypeName = "NastavnoOsoblje")]
    public class NastavnoOsoblje: StalniUposleni
    {
        //int brojPredmeta; 
        [XmlIgnore] private Image korisnickaSlika;
        private string korisnickoIme, lozinka; //DODATI U KONSTRUKTOR KAO I BACH I MAST

        public NastavnoOsoblje(string im, string prez, DateTime dr, string maticni,  string poz, string ss, string t, decimal p, string kime, string loz) : 
           base(im, prez, dr,maticni,poz, ss, t, p)
        {
            KorisnickoIme = kime;
            Lozinka = loz;

        }

        public NastavnoOsoblje() { }
        public override void dodajSliku(Image s)
        {
            KorisnickaSlika = s;
        }
        public void ObracunPlate(int brp)
        {
            Plata += brp * 0.32m;
        }
        public override string ToString()
        {
            return "Ime i prezime: " + Ime + " " + Prezime +"\n"+ " Pozicija: " + Pozicija;
        }

        public override string DajIme()
        {
            return Ime;
        }
        public override string dajPrezime()
        {
            return Prezime;
        }
        public override string dajKorisnickoIme()
        {
            return KorisnickoIme;
        }
        public override string dajLozinku()
        {
            return Lozinka;
        }
        public override string dajSifru()
        {
            return Convert.ToString(Sifra);
        }
        public override string dajDatum()
        {
            return Convert.ToString(DatumRodjenja);
        }
        public override string dajDatumZavrsetka()
        {
            return string.Empty;
        }
        public override string dajStrucnu()
        {
            return SSprema;
        }
        public override string dajTitulu()
        {
            return Titula;
        }
        public override string dajPoziciju()
        {
            return Pozicija;
        }
        public override string dajIznosPlate()
        {
            return Convert.ToString(Plata);
        }
        public override string dajPredmet()
        {
            return string.Empty ;
        }
        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }

            set
            {
                korisnickoIme = value;
            }
        }

        public string Lozinka
        {
            get
            {
                return lozinka;
            }

            set
            {
                lozinka = value;
            }
        }

        public Image KorisnickaSlika
        {
            get
            {
                return korisnickaSlika;
            }

            set
            {
                korisnickaSlika = value;
            }
        }
    }
}
