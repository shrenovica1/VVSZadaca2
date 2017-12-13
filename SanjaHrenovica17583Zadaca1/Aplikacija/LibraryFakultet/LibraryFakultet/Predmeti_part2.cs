using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;


namespace FakultetLibrary
{
   // [Serializable()]
    public partial class Predmeti
    {
        
        public int Sifra
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

        public int BrojVjezbi
        {
            get
            {
                return brojVjezbi;
            }

            set
            {
                brojVjezbi = value;
            }
        }

        public int BrojPredavanja
        {
            get
            {
                return brojPredavanja;
            }

            set
            {
                brojPredavanja = value;
            }
        }

        public int BrojStudenata
        {
            get
            {
                return brojStudenata;
            }

            set
            {
                brojStudenata = value;
            }
        }

        public int BrojETCS
        {
            get
            {
                return brojETCS;
            }

            set
            {
                brojETCS = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public string Studij
        {
            get
            {
                return studij;
            }

            set
            {
                studij = value;
            }
        }

        internal List<NastavnoOsoblje> Lista
        {
            get
            {
                return lista;
            }

            set
            {
                lista = value;
            }
        }

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
    }
}
