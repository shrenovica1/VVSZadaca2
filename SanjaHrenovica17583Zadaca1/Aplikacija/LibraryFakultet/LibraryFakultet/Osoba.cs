using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using System.Drawing;
using System.Threading.Tasks;
using Validacija17583;
using System.Xml.Serialization;

namespace FakultetLibrary
{
    [Serializable()]
    [XmlInclude(typeof(Bachelor))]
    [XmlInclude(typeof(Master))]
    [XmlInclude(typeof(StalniUposleni))]
    [XmlInclude(typeof(PrivremeniUposlenici))]
    [XmlInclude(typeof(NastavnoOsoblje))]
    [XmlInclude(typeof(NenastavnoOsoblje))]
    abstract public class Osoba
    {
        
        private string ime, prezime;
        private string jmbg;
        private DateTime datumRodjenja;
        public Osoba(string im, string prez, DateTime dr, string maticni)
        {
           
                Ime = im;
                Prezime = prez;
                Jmbg = maticni;
                DatumRodjenja = dr;
            
        }
       // public string Ime { get; set; }

        public Osoba(){}
        public static  void UcitajUDat(Osoba oso, string datoteka)
        {
            XmlSerializer serijalizacija = new XmlSerializer(typeof(Osoba));
            StreamWriter pisac = new StreamWriter(datoteka);
            serijalizacija.Serialize(pisac, oso);
            pisac.Close();

        }
        public override string ToString()
        {
         return "Ime i prezime: " + Ime +" "+ Prezime+ "\n" + "JMBG: " + Jmbg + "\n" + "Datum rodjenja: " + DatumRodjenja;
           
        }
        public virtual void dodajSliku(Image s) {}
        public string DajMaticniBroj()
        {
            return Jmbg;
        }
        public virtual string DajIme()
        {
            return Ime;
        }
        public virtual string dajPrezime()
        {
            return Prezime;
        }
        public virtual string dajKorisnickoIme() { return "s"; }
        public virtual string dajLozinku() { return "s"; }

        public virtual string HesSifru(string s)
        {
            string sSourceData = s;
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string vrati = BitConverter.ToString(tmpHash).Replace("-", string.Empty).ToLower();
            return vrati;
        }
        public virtual  string dajSifru()
        {
            return string.Empty;
        }
        public virtual string dajDatum()
        {
            return string.Empty;
        }
        public virtual string dajDatumZavrsetka()
        {
            return string.Empty;
        }
        public virtual string dajStrucnu()
        {
            return string.Empty;
        }
        public virtual string dajTitulu()
        {
            return string.Empty;
        }
        public virtual string dajPoziciju()
        {
            return string.Empty;
        }
        public virtual string dajIznosPlate()
        {
            return string.Empty;
        }
        public virtual string dajPredmet()
        {
            return string.Empty;
        }



        public string Ime
        {
            get
            {
                return ime;
            }

            set { 

                if (value == null|| value=="") throw new ArgumentException("Ime ne moze biti prazno");
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

       

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {

                datumRodjenja = value;
               
            }
        }
        public string Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {

                if (value.Length != 13) throw new ArgumentException("JMBG mora imati 13 znamenki");
              
                jmbg = value;
            }
        }
    }
}
