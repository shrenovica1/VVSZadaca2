using FakultetLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    public class Studentska
    {
        public IStudentska sluzba;

        public Studentska(IStudentska service) {
            sluzba = service;
        }
        public int brojStudenata()
        {
            return sluzba.brojStudenata();
        }

        public string dajPotvrdu(int index)
        {
            return sluzba.dajPotvrdu(index);
        }

        public List<Predmeti> polozeniPredmeti(Bachelor b)
        {
            return sluzba.polozeniPredmeti(b);
        }
        public void prijaviIspit(Predmeti p) {
             sluzba.prijaviIspit(p);
        }
        public List<Predmeti> prijavljeniIspiti() {
            return sluzba.prijavljeniIspiti();
        }
    }
}
