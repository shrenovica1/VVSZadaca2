using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacija17583
{
    public class validacija
    {
        private static System.Collections.Generic.List<string> indeksi = new System.Collections.Generic.List<string>();
        private static System.Collections.Generic.List<string> maticni = new System.Collections.Generic.List<string>();
        static string jmbg;
        public static bool ValidacijaJmbgDatum(DateTime dr)
        {
            string s = dr.ToString();
            string prvih7 = s.Substring(0, 2) + s.Substring(3, 2) + s.Substring(7, 3);
            string dRodjenja = jmbg.Substring(0, 7);
            if (dRodjenja != prvih7) return false;
            else return true;
        }
        public static bool ValidacijaMaticnogBroja(string br)
        {
            jmbg = br;
            if (br.Length == 13)
           
                return true;
            
            else return false;
        }
        public static bool ValidacijaMbr(string broj)
         {
            string br = broj;
           
            System.Collections.Generic.List<int> mmat = new System.Collections.Generic.List<int>();
            int suma = 0;
           
            for (int i = 0; i < br.Length; i++)
            {
                
                mmat.Add(br[i] - 48);
              
            }
            int j = 7;
            for (int i = 0; i < 6; i++)
            {
                suma += mmat[i] * j;
                j--;
              
            }
            j = 7;
            for (int i = 6; i < 12; i++)
            {

                suma += mmat[i] * j;
                j--;
            }
            int pr = Convert.ToInt32(suma % 11);
            if ((11 - pr) == mmat[12])  return true; 
            else if(pr==0 && mmat[12]==pr) return true;
            else return false;

        }
        public static bool ValidacijaIndeksa(string ind)
        {
            if (Indeksi.Contains(ind)) return false;
            else Indeksi.Add(ind);
            return true;

        }
        public static bool ValidacijaDatumaUpisa(DateTime dzpo)
        {
            DateTime a = DateTime.Now;
            if (dzpo < a) return true;
            else return false;
        }
        public static bool ValidacijaJedinstvenosti(string jmbg)
        {
            if (Maticni.Contains(jmbg)) return false;
            else Maticni.Add(jmbg);
            return true;
        }


        public static List<string> Indeksi
        {
            get
            {
                return indeksi;
            }

            set
            {
                indeksi = value;
            }
        }

        public static List<string> Maticni
        {
            get
            {
                return maticni;
            }

            set
            {
                maticni = value;
            }
        }


    }
}
