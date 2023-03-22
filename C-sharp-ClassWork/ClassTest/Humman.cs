using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Humman
    {
        public int MyProperty { get; set; }

        public int HumanMonth(int age)
        {
            const byte month = 12;
            return age * month;
        }

        readonly short day = 365;
        public int HumanDay(int age)
        {
            return age * day;
        }
    }
}
