using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubTest
{
    public class DummyOcjenacs : IOcjeni
    {
        public decimal boduj(int i)
        {
            return 3 * i;
        }

        public bool daLiJeOcjenjena()
        {
            return true;
        }

        public string komentarNaZadacu()
        {
            return "Primjer komentara";
        }
    }
}
