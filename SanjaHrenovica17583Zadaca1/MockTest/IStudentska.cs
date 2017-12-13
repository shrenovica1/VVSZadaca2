using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakultetLibrary;

namespace MockTest
{
    public interface IStudentska
    {
        int brojStudenata( );
        String dajPotvrdu(int index);

        List<Predmeti> polozeniPredmeti(Bachelor b);
        //u smislu da profesori prijave ispit iz svog predmeta na studentsku sluzbu
        void prijaviIspit(Predmeti p);

        List<Predmeti> prijavljeniIspiti();
    }
}
