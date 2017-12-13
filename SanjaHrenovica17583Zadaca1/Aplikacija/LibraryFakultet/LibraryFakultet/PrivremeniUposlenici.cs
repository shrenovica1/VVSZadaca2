using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;
using Validacija17583;
namespace FakultetLibrary
{
    [Serializable]
    [XmlType(TypeName="PrivremeniUposlenici")]
    public sealed class PrivremeniUposlenici: Osoba
    {
        int sifra2 = 12122;
        private DateTime datumPotpisivanja;
        private DateTime datumIsteka;
        private decimal plata;
        string pozicija, sSprema, titula;
        public PrivremeniUposlenici(string im, string prez, DateTime dr, string maticni,  string poz, string ss, string t, decimal p,
            DateTime dp, DateTime di) : base(im, prez, dr,maticni)
        {
            Pozicija = poz;
            SSprema = ss;
            Titula = t;
            Plata = p;
            DatumIsteka = di;
            DatumPotpisivanja = dp;
            Sifra2++;
        }
        public PrivremeniUposlenici() { }
        public override string ToString()
        {
              return "Ime i prezime: " + Ime + " " + Prezime + "\n" + " Pozicija: " + Pozicija;
        }
        public override string DajIme()
        {
            return Ime;
        }
        public override string dajPrezime()
        {
            return Prezime;
        }
        
        public override string dajSifru()
        {
            return Convert.ToString(Sifra2);
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
            return string.Empty;
        }
        public decimal DajPlatu()
        {
            return Plata;
        }
        public DateTime DatumPotpisivanja
        {
            get
            {
                return datumPotpisivanja;
            }

            set
            {
                datumPotpisivanja = value;
            }
        }

        public DateTime DatumIsteka
        {
            get
            {
                return datumIsteka;
            }

            set
            {
                datumIsteka = value;
            }
        }

        public decimal Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }

        public string Pozicija
        {
            get
            {
                return pozicija;
            }

            set
            {
                pozicija = value;
            }
        }

        public string SSprema
        {
            get
            {
                return sSprema;
            }

            set
            {
                sSprema = value;
            }
        }

        public string Titula
        {
            get
            {
                return titula;
            }

            set
            {
                titula = value;
            }
        }

        public int Sifra2
        {
            get
            {
                return sifra2;
            }

            set
            {
                sifra2 = value;
            }
        }
    }
}
