using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomClass2
{
    internal class Class1
    {
        public Class1()
        {
            Console.WriteLine(MakePlus(10, 20));
        }
        public Class1(int a, int b)
        {
            Console.WriteLine(MakePlus(a, b));
        }
       

        public int MakePlus(int a, int b)
        {
            return a + b;
        }

        public int MakeMult(int a, int b)
        {
            return a * b;
        }
    }
}
