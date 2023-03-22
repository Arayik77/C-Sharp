namespace Methods
{
    internal class Program
    {

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void PrintLine(int result)
        {
            Console.WriteLine("My numbers summary is " + result);
        }

        static void Work1(string d, int e)
        {
            for (int i = 0; i < e; i++)
            {
                Console.Write(d);
            }

        }

        static void Main(string[] args)
        {
            //int a, b, c;

            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            //c = Sum(a, b);

            //PrintLine(c);

            // home work 1
            Console.WriteLine("Enter simbol");
            string d = Console.ReadLine();
            Console.WriteLine("Enter simbol count");
            int e = int.Parse(Console.ReadLine());
            Work1(d, e);

        }
    }
}