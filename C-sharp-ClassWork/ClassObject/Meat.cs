using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    static partial class Meat
    {
        static public int Qyabab(int priceQyabab, int quantity)
        {
            return priceQyabab * quantity;
        }
        static public int Shaurma(int priceShaurma, int quantity)
        {
            return priceShaurma * quantity;
        }

        //static public Meat()
        //{
        //    Console.WriteLine("nothing");
        //}

        //static public Meat(int priceShaurma, int quantity)
        //{
        //    Console.WriteLine("giny " + priceShaurma + " quantity " + quantity);
        //}

        //static public Meat(int priceShaurma, int priceQyabab, int quantity)
        //{
        //    Console.WriteLine("shaurmayi giny " + priceShaurma + ", qyababi giny " + priceQyabab + ", qanaky " + quantity);
        //}
    }
}
