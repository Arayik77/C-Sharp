using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car
    {

        public MatorType Mator { get; set; }
        public string Shofer { get; set; }
        public string Erkir { get; set; }
        public bool Farer { get; set; }

        public Car()
        {
            
        }
        public Car(bool k)
        {
            Farer = k;
        }

    }

    public enum MatorType
    {
        meknoc,
        mekukesnoc,
        ereqnoc
    }
}
