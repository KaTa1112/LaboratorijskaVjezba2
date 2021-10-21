using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskaVjezba2
{
    class KomplekniBrojKlasa
    {
        public KomplekniBrojKlasa(double realni, double imaginarni)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }
        public double RealniDio;
        public double ImaginarniDio;

        public override string ToString()
        {
            return $"({RealniDio},{ImaginarniDio})";//sve u zagradama su varijable
        }
    }

}
