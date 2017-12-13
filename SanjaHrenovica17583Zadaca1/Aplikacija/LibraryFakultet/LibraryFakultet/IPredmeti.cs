using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakultetLibrary
{
   public  interface IPredmeti
    {
        void DodajUAnsambl(NastavnoOsoblje pa);
        int ETCSuSate();
       // int brojPredmetaZaProfesora(int s);
        System.Collections.Generic.List<NastavnoOsoblje> Ansambl();
        void GeneralneInformacije();
        string DajNazivPredmeta();
        int dajSifruPredmeta();
        int BrETCS();

    }
}
