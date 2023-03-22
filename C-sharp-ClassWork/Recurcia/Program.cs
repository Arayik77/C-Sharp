namespace Recurcia
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Rec rec = new Rec();
            Console.WriteLine(rec.RecurciaMult(5));
            Console.WriteLine(rec.Multiple(10, 20, null, 40));
        }
    }
}