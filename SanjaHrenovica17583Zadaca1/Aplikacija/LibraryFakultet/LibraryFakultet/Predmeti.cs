using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace FakultetLibrary
{
    [Serializable()]
    public partial class Predmeti : IPredmeti
    {
        static int sifra = 100;
        private int brojVjezbi, brojPredavanja, brojStudenata, brojETCS;
        private string opis, studij, naziv;
        private System.Collections.Generic.List<NastavnoOsoblje> lista;
        public Predmeti(string naziv, int bv, int bp, int bs, int be, string op, string stud)
        {
            Sifra = ++Sifra;
            BrojStudenata = bs;
            BrojVjezbi = bv;
            BrojPredavanja = bp;
            BrojETCS = be;
            Opis = op;
            Naziv = naziv;
            Studij = stud;
            Lista = new System.Collections.Generic.List<NastavnoOsoblje>();

        }
        public Predmeti() { }
        public int brVjezbi() { return BrojVjezbi; }
        public int brETCS() { return BrojETCS; }
        public int brPredavanja() { return BrojPredavanja; }
        public int brStudenata() { return BrojStudenata; }
        public string dajStudij() { return Studij; }
        public string dajOpis() { return Opis; }

        public void GeneralneInformacije()
        {
          //  Console.WriteLine("{0}, {1}, {2}, {3}, {4}", Sifra, BrojStudenata, BrojVjezbi, BrojPredavanja, BrojETCS);
           // Console.WriteLine("{0}, {1}", Opis, Studij);
        }
        public string DajNazivPredmeta()
        {
            return Naziv;
        }
        public System.Collections.Generic.List<NastavnoOsoblje> Ansambl() { return Lista; }
        public void DodajUAnsambl(NastavnoOsoblje pa)
        {
            Lista.Add(pa);
        }
        public int dajSifruPredmeta() { return Sifra; }
        public int ETCSuSate() { return BrojETCS * 25; }
        public override string ToString()
        {
            return "Sifra predmeta: " + Sifra + "\n" + "Broj ETCS bodova: " + BrojETCS + " \n" + "Opis predmeta: " + Opis;
        }
        public int BrETCS() { return BrojETCS; }
    }

      
    
}
 