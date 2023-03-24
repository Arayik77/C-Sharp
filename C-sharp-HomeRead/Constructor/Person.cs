using System.Xml.Linq;

namespace Constructor
{
    internal class Person
    {
        public string SecondName { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName;
            }
        }

        public string ShortName
        {
            get
            {
                return $"{SecondName} {FirstName.Substring(0, 1)}.";
            }
        }

        // constructor start

        public Person(string firstName, string secondName)
        {
            firstName = FirstName;
            secondName = SecondName;
        }

        // constructor end

        ////public string Name;

        //private string _name;

        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }

        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("anuny chi karox line   l datark");
        //        }

        //        _name = value;
        //    }
        //} // nuyn banna inch nerqevi comment um exacy



        ////public string GetName()
        ////{
        ////    return _name;
        ////}

        ////public void SetName(string name)
        ////{
        ////    if(string.IsNullOrWhiteSpace(name))
        ////    {
        ////        throw new ArgumentNullException("anuny chi karox linel datark");
        ////    }
        ////        _name = name;
        ////}
    }
}
