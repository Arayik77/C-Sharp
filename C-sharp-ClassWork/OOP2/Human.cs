using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Human
    {
        public Human()
        {

        }

        public Human(short age)
        {
            Age = age;
        }
        public string Name { get; set; }
        public string Surnamae { get; set; }
        public short Age { get; set; }
        public GenderEnum Gender { get; set; }
        public string Test { get; set; }

        //public void publicHelloMen()
        //{
        //    Console.WriteLine("Barev mard");
        //}
        
        //internal void internalByMen()
        //{
        //    Console.WriteLine("ByMen");
        //}
        
        //protected void protectedWhyMen()
        //{
        //    Console.WriteLine("WhyMen");
        //}

        //private void _privateWhyMen()
        //{
        //    Console.WriteLine("WhyMen");
        //}

    }

    public enum GenderEnum
    {
        Boy,
        Girl,
        Esiminch
    }
}
