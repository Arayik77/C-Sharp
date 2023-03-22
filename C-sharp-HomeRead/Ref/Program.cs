using System.Diagnostics;

namespace Ref
{
    internal class Program
    {

        //static void ChangeValue(out int value)
        //{
        //    value = 100;
        //}
        //static void Main(string[] args)
        //{
        //    //int number1 = 5;
        //    ChangeValue(out int number1);

        //    Console.WriteLine(number1);

        //    number1 = 5;

        //    Console.WriteLine(number1);
        //}




        //static void Main(string[] args)
        //{
        //    string number = "436547";

        //    int.TryParse(number, out int result);

        //    Console.WriteLine(result);
        //}



        struct Example
        {
            public decimal number1;
            public decimal number2;
            public decimal number3;
            public decimal number4;
            public decimal number5;
        }


        //static void ReadValue(in int value)
        //{
        //    Console.WriteLine(value);
        //}

        static void ReadValue(Example example)
        {
        }

        static void ReadValue2(in Example example)
        {
        }


        static void Main(string[] args)
        {
            //int number = 100;

            Example ex1 = new Example();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < int.MaxValue; i++)
            {
                ReadValue(ex1);
            }

            Console.WriteLine($"Time in milliseconds {sw.ElapsedMilliseconds}");
            sw.Restart();
            sw.Stop();
            //----------------------//

            sw.Start();

            for (int i = 0; i < int.MaxValue; i++)
            {
                ReadValue2(in ex1);
            }

            Console.WriteLine($"Time in milliseconds {sw.ElapsedMilliseconds}");
            sw.Restart();
            sw.Stop();
        }
    }
}