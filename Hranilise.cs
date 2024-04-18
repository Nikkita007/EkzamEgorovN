using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamEgorovN
{
    internal class Hranilise
    {
        int podsch;
       
        public Hranilise(int Obm, int vzal)
        {
            podsch = Obm - vzal;
         

        }
        public int Podschet()
        {
            return podsch;
        }

       
    }
}
