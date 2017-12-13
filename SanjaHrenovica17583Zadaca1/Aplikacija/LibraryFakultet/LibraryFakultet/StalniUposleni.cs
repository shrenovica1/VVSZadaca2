using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;
using Validacija17583;
namespace FakultetLibrary
{
    [Serializable]
    [XmlInclude (typeof(NastavnoOsoblje))]
    [XmlInclude(typeof(NenastavnoOsoblje))]
    public class StalniUposleni : Osoba
    {     
        string pozicija, sSprema, titula;
        static int sifra = 111;
        decimal plata;//treba li biti u konstruktoru?
        public StalniUposleni(string im, string prez,  DateTime dr, string maticni,  string poz, string ss, string t, decimal p) : base(im, prez, dr, maticni)
        {
            Pozicija = poz;
            SSprema = ss;
            Titula = t;
            Plata = p;
            Sifra++;
        }
        public StalniUposleni() { }
        public override string ToString()
        {
            return "Ime i prezime: " + Ime + " " + Prezime + "\n" + " Pozicija: " + Pozicija;
        }
        public decimal  DajPlatu()
        {
            return Plata;
        }
        public int DajSifruUposlenika()
        {
            return Sifra;
        }
        public override void dodajSliku(Image s){}
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

        public static int Sifra
        {
            get
            {
                return sifra;
            }

            set
            {
                sifra = value;
            }
        }
    }
}
