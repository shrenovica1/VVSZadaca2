using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Validacija17583;
using System.Security.Cryptography;

namespace FakultetLibrary
{
    [Serializable()]
    //[XmlType("Bachelor.Master")]
    [XmlInclude(typeof(Master))]
    [XmlType(TypeName="Bachelor")]
    public class Bachelor: Osoba
    {
        [XmlIgnore]  private Image korisnickaSlika;
        private string korisnickoIme, lozinka, preHesLozinka;
        [XmlIgnore] private System.Collections.Generic.List<Predmeti> polozeniPredmeti;
        [XmlIgnore] private System.Collections.Generic.List<Predmeti> polozeniPredmetiAktivni;
        //private System.Collections.Generic.List<Predmeti> sviPredmeti;
        private DateTime datumZavrsenjaPO;
       private static int pocetnii = 16000;
        private int index;
        public Bachelor(string im, string prez, DateTime dr, string maticni, DateTime dzpo, string ki, string kp) : base(im, prez, dr,maticni)
        {
            KorisnickoIme = ki;
            Lozinka = HesSifru(kp);
            PreHesLozinka = kp;
            DatumZavrsenjaPO = dzpo;
            Index =  Pocetnii++;
            PolozeniPredmeti = new System.Collections.Generic.List<Predmeti>();
            PolozeniPredmetiAktivni= new System.Collections.Generic.List<Predmeti>();
            
        }
        public Bachelor(){ }
        public virtual void dodajSliku(Image s)
        {
            KorisnickaSlika = s;
        }
        public String dajDatum() {
            return DatumRodjenja.ToString("dd.MM.yyyy");
        }
       /* public static void UcitajUDat(Osoba oso, string datoteka)
        {
            XmlSerializer serijalizacija = new XmlSerializer(typeof(Osoba));
            StreamWriter pisac = new StreamWriter(datoteka);
            serijalizacija.Serialize(pisac, oso);
            pisac.Close();

        }*/
        public override string ToString()
        {
            return "Ime i prezime: " + Ime + "  " + Prezime + "\n" + " Index: " + Index;
        }
       public virtual string DajBrojIndexa()
        {
            return Convert.ToString(Index);
        }
        public override string dajKorisnickoIme()
        {
            return KorisnickoIme;
        }
        
        public virtual string dajMjesto()
        {
            return string.Empty;
        }
        public override string dajLozinku()
        {
            return PreHesLozinka;
        }
        public virtual void DodajAktivniPredmet(Predmeti p)//Aktivni predmeti
        {
            int suma = 0;
            foreach (Predmeti pred in PolozeniPredmetiAktivni) suma += pred.brETCS();
            if(suma<=30)  PolozeniPredmetiAktivni.Add(p);
        }
        public virtual void DodajPredmet(Predmeti p)//Arhivirani predmeti
        {
            PolozeniPredmeti.Add(p);
        }
        public virtual void ukloniPredmet(string ime)
        {
            foreach (Predmeti pr in PolozeniPredmetiAktivni)
            {
                if (pr.DajNazivPredmeta() == ime) PolozeniPredmetiAktivni.Remove(pr);
            }
        }

        public virtual System.Collections.Generic.List<Predmeti> DajSpisakPPredmeta() {
            return PolozeniPredmeti;
        }
        public virtual System.Collections.Generic.List<Predmeti> dajAktivnePredmete()
        {
            return PolozeniPredmetiAktivni;
        }
        public override string HesSifru(string s)
        {
            string sSourceData = s;
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string vrati = BitConverter.ToString(tmpHash).Replace("-", string.Empty).ToLower();
            return vrati;
        }

        public DateTime DatumZavrsenjaPO
        {
            get
            {
                return datumZavrsenjaPO;
            }

            set
            {
                if (validacija.ValidacijaDatumaUpisa(value)) datumZavrsenjaPO = value;
                else throw new Exception("Neispravan datum zavrsetka prethodnog obrazovanja");
            }
        }

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

       

        public int Pocetnii
        {
            get
            {
                return pocetnii;
            }

            set
            {
                pocetnii = value;
            }
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

        public string PreHesLozinka
        {
            get
            {
                return preHesLozinka;
            }

            set
            {
                preHesLozinka = value;
            }
        }

        public List<Predmeti> PolozeniPredmeti
        {
            get
            {
                return polozeniPredmeti;
            }

            set
            {
                polozeniPredmeti = value;
            }
        }

        public List<Predmeti> PolozeniPredmetiAktivni
        {
            get
            {
                return polozeniPredmetiAktivni;
            }

            set
            {
                polozeniPredmetiAktivni = value;
            }
        }
    }
}
