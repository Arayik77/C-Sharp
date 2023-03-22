namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.WriteLine("You write number 1");
                    break;
                case 2:
                    Console.WriteLine("You write number 2");
                    break;
                case 3:
                    Console.WriteLine("You write number 3");
                    break;
                default:
                    Console.WriteLine("You don't write number");
                    break;
            }
        }
    }
}