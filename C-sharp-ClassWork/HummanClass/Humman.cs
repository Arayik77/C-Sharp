using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HummanClass
{
    internal class Humman
    {
        public bool isValid(string str)
        {
            for(int i =  0; i < str.Length; i++)
            {
                if (!(str[i] >= 'a' && str[i] <= 'z') || !(str[i] >= 'A' && str[i] <= 'Z'))
                    return false;
            }

            return true;
        }

    }
}
