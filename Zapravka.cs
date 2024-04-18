using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamEgorovN
{
    internal class Zapravka
    {
        int podsch;
        int podsch2;
        public Zapravka(int Obm, int vzal, int dobavil)
        {

            podsch = Obm - vzal;
            podsch2 = podsch + dobavil;
        }

        public int Zapravit()
        {
            return podsch2;
        }
    }
}
