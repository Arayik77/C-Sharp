using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HummanApp
{
    internal class Humman
    {

        // name and surname count
        public int PersonNameCount(string name)
        {
            int countName = name.Length;
            return countName;
        }
        
        public int PersonSurnameCount(string surname)
        {
            int countSurname = surname.Length;
            return countSurname;
        }


        // name and surname validation

        public bool PersonNameValidation(string name)
        {

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z')
                {
                    return true;
                }
            }
            return false;
        }

        public bool PersonSurnameValidation(string surname)
        {
            for (int i = 0; i < surname.Length; i++)
            {
                if (surname[i] >= 'a' && surname[i] <= 'z' || surname[i] >= 'A' && surname[i] <= 'Z')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
