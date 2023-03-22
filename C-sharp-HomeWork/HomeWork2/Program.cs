namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // data types

            byte myByte = 1;
            short myShort = 5;
            int myInt = 10;
            long myLong = 100;
            float myFloat = 117;
            double myDouble = 12.3;
            decimal myDecimal = 125;
            int myBdayMonth = 5;

            int summary1 = myByte + myShort;
            int summary2 = myByte - myInt;
            var summary3 = myLong * myFloat;
            double summary4 = myDouble / myShort;
            decimal summary5 = myDecimal % myShort;

            Console.WriteLine(summary1);
            Console.WriteLine(summary2);
            Console.WriteLine(summary3);
            Console.WriteLine(summary4);
            Console.WriteLine(summary5);

            // statements

            // type 1

            if(myByte > myShort)
            {
                Console.WriteLine("yes");
            } else
            {
                Console.WriteLine("no");
            }

            // type 2

            if (summary3 >= summary4) Console.WriteLine("yes"); else Console.WriteLine("no");

            // switch

            switch(myBdayMonth)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Fabruary");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("Jule");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }

        }
    }
}