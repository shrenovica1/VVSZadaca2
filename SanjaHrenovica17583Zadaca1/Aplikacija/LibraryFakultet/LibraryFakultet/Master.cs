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
    [Serializable()]
    [XmlType(TypeName = "Master")]
   public class Master : Bachelor
    {

        [XmlIgnore] private Image korisnickaSlika;
        private string korisnickoIme, lozinka, preHesLozinka;
        [XmlIgnore] private System.Collections.Generic.List<Predmeti> sviPredmeti;
        [XmlIgnore] private System.Collections.Generic.List<Predmeti> polozeniPredmeti;
     
        private DateTime datumZavrsenja;
        private string noviIndeks = "";
        private string mjesto="";
        [XmlIgnore] static int prijebr = 100;
        public Master(string im, string prez,  DateTime dr, string maticni, DateTime dpzo, int ind, string mjesto, string ki, string kp) : base(im, prez, dr,maticni,dpzo,ki,kp)
        {
            DatumZavrsenjaPO = dpzo;
            KorisnickoIme1 = ki;
            Lozinka1 = HesSifru(kp);
            preHesLozinka = kp;
            Prijebr++;
            NoviIndeks = Prijebr.ToString() + "/" +ind.ToString();
            PolozeniPredmeti1 = new System.Collections.Generic.List<Predmeti>();
            SviPredmeti = new System.Collections.Generic.List<Predmeti>();
            Mjesto = mjesto;
        }
        public Master() {}
        public override void dodajSliku(Image s)
        {
            KorisnickaSlika = s;
        }
        public override string ToString()
        {
            return "Ime i prezime: " + Ime + "  " + Prezime + "\n" + " Index: " + NoviIndeks;
        }
        public override string DajBrojIndexa()
        {
            return NoviIndeks;
        }
        public override void DodajAktivniPredmet(Predmeti p)
        {
            PolozeniPredmeti1.Add(p);
        }
        public override void DodajPredmet(Predmeti p)
        {
            SviPredmeti.Add(p);
        }
        public override void ukloniPredmet(string ime)
        {
            foreach (Predmeti pr in PolozeniPredmeti1)
            {
                if (pr.DajNazivPredmeta() == ime) PolozeniPredmeti1.Remove(pr);
            }
        }
        public override string dajMjesto()
        {
            return Mjesto;
        }
        public override string dajKorisnickoIme()
        {
            return KorisnickoIme;
        }
        public override string dajLozinku()
        {
            return preHesLozinka;
        }
        public override System.Collections.Generic.List<Predmeti> DajSpisakPPredmeta()
        {
            return SviPredmeti;
        }
        public void NapraviNoviIndex()
        {
            NoviIndeks = Prijebr.ToString() + "/"+ (++Pocetnii).ToString();
        }
        public override System.Collections.Generic.List<Predmeti> dajAktivnePredmete()
        {
            return PolozeniPredmeti1;
        }
       public string Mjesto
        {
            get
            {
                return mjesto;
            }

            set
            {
                mjesto = value;
            }
        }

       public string NoviIndeks
        {
            get
            {
                return noviIndeks;
            }

            set
            {
                //if (validacija.ValidacijaIndeksa(NoviIndeks))
                    noviIndeks = value;
               //else throw new Exception("Neispravan index");
            }
        }

        public DateTime DatumZavrsenja
        {
            get
            {
                return datumZavrsenja;
            }

            set
            {
                datumZavrsenja = value;
            }
        }

        public string KorisnickoIme1
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

        public string Lozinka1
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

        public Image KorisnickaSlika1
        {
            get
            {
                return KorisnickaSlika2;
            }

            set
            {
                KorisnickaSlika2 = value;
            }
        }

        public Image KorisnickaSlika2
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

        public List<Predmeti> SviPredmeti
        {
            get
            {
                return sviPredmeti;
            }

            set
            {
                sviPredmeti = value;
            }
        }

        public List<Predmeti> PolozeniPredmeti1
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

        public static int Prijebr
        {
            get
            {
                return prijebr;
            }

            set
            {
                prijebr = value;
            }
        }
    }
}
