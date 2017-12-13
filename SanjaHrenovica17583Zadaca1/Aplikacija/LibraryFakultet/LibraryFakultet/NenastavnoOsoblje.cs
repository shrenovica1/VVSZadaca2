using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Validacija17583;
namespace FakultetLibrary
{
    [Serializable]
    [XmlType(TypeName="NenastavnoOsoblje")]
    public class NenastavnoOsoblje: StalniUposleni
    {
        public NenastavnoOsoblje(string im, string prez, DateTime dr, string maticni,  string poz, string ss, string t, decimal p) :
            base(im,prez,dr,maticni,poz,ss,t,p)
        {
            Plata+= p * 0.32m;
        }
        public NenastavnoOsoblje() { }
        public override string DajIme()
        {
            return Ime;
        }
        public override string ToString()
        {
            return "Ime i prezime: " + Ime + " " + Prezime + "\n" + " Pozicija: " + Pozicija;
        }
        public override string dajPrezime()
        {
            return Prezime;
        }
        
        public override string dajSifru()
        {
            return Convert.ToString(Sifra);
        }
        public override string dajDatum()
        {
            return Convert.ToString(DatumRodjenja);
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
       

    }
}
