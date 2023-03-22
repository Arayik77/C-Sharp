using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestMilk
{
    internal class Milk
    {
        public int MakeSmetan(int quantity)
        {
            const short price = 120;
            return price * quantity;
        }

        public int MakeMatzoon(int quantity)
        {
            const short price = 360;
            return price * quantity;
        }

        public int MakeTvarog(int quantity)
        {
            const short price = 420;
            return price * quantity;
        }
    }
}
