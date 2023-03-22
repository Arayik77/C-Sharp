using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatukSoluition
{
    public enum Menu
    {
        HotDog=500,
        Sushi=12000,
        Pizza=300,
        Shaurma=750,
        Xash=1350
    }
    internal class Restaurant
    {
        public Restaurant()
        {
            
        }

        public Restaurant(int u)
        {
            t = u;
        }
        public int t;
        public const string Address = "Abovyan-1";
        public const string Number = "+37497777777";

        public decimal MakeFood(Menu menu, int count)
        {
            switch (menu)
            {
                case Menu.HotDog:
                    return (decimal)Menu.HotDog * (count + t);
                case Menu.Sushi:
                    return (decimal)Menu.Sushi * (count + t);
                case Menu.Pizza:
                    return (decimal)Menu.Pizza * (count + t);
                case Menu.Shaurma:
                    return (decimal)Menu.Shaurma * (count + t);
                case Menu.Xash:
                    return (decimal)Menu.Xash * (count + t);
                default:
                    return 0;
            }

        }


    }
}