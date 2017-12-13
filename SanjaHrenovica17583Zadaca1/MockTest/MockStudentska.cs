using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakultetLibrary;
using LibraryFakultet;

namespace MockTest
{
    public class MockStudentska : IStudentska
    {
        IList<Bachelor> studenti;
        IList<Potvrda> potvrda;
        List<Predmeti> ispiti;
        Fakultet f;
        public MockStudentska(Fakultet f) {
            F = f;
            studenti = new List<Bachelor>();
            potvrda = new List<Potvrda>();
            ispiti = new List<Predmeti>();
        }

        public Fakultet F { get => f; set => f = value; }

        public int brojStudenata()
        {
            return F.BrojStudenata();
        }

        public string dajPotvrdu(int index)
        {
            foreach (Potvrda p in potvrda) {
                if (p.Student.DajBrojIndexa() == index.ToString()) {

                    return p.Svrha + "Status potvrde: " + p.Obradjena;
                }
            }
            return "Podnesite zahtjev za potvrdu";
        }

        public List<Predmeti> polozeniPredmeti(Bachelor b) {
            return b.DajSpisakPPredmeta();
        }

        
        public void prijaviIspit(Predmeti p) {
            if(ispiti.Contains(p)==false) ispiti.Add(p);
        }
        public List<Predmeti> prijavljeniIspiti() {
            return ispiti;
        }
    }
}
