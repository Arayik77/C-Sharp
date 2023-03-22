using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurcia
{
    internal class Rec
    {
        public int RecurciaMult(int a)
        {
            if(a == 1)
            {
                return 1;
            }

            return a * RecurciaMult(a - 1);
        }

        public int? Multiple(int? a, int? b, int? c, int? d)
        {
            return a * b * c * d;
        }
    }
}
