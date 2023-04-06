namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 0:
                    Console.WriteLine("You write 0");
                    break;
                case 1:
                    Console.WriteLine("You write 1");
                    break;
                case 2:
                    Console.WriteLine("You write 2");
                    break;
                case 3:
                    Console.WriteLine("You write 3");
                    break;
                case 4:
                    Console.WriteLine("You write 4");
                    break;
                case 5:
                    Console.WriteLine("You write 5");
                    break;
                case 6:
                    Console.WriteLine("You write 6");
                    break;
                case 7:
                    Console.WriteLine("You write 7");
                    break;
                case 8:
                    Console.WriteLine("You write 8");
                    break;
                case 9:
                    Console.WriteLine("You write 9");
                    break;
                case 10:
                    Console.WriteLine("You write 10");
                    break;
                default: 
                    Console.WriteLine("write correct");
                    break;
            }
        }
    }
}