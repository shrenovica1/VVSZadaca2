using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubTest
{
   public class ocjenaZadace
    {
        IOcjeni ocjena;
        public ocjenaZadace() {
            ocjena = new SistemOcjenjivanja();
        }
        public ocjenaZadace(IOcjeni ocjena1) {
            ocjena = ocjena1;
        }

        public decimal boduj(int i) {
            return ocjena.boduj(i)/2;
        }
       public Boolean daLiJeOcjenjena() {
            return ocjena.daLiJeOcjenjena();
        }

       public String komentarNaZadacu() {
            return "Komentar: "+ocjena.komentarNaZadacu();
        }



    }
}
