using FakultetLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFakultet
{
    public class Potvrda
    {
        private Bachelor student;
        Boolean obradjena;
        String svrha;
        public Potvrda(Bachelor b,  String s) {
            Student = b;
            Obradjena = false;
            Svrha = s;
        }
        public Potvrda() { Obradjena = false; }

        public Bachelor Student { get => student; set => student = value; }
        public bool Obradjena { get => obradjena; set => obradjena = value; }
        public string Svrha { get => svrha; set => svrha = value; }

        


    }
}
