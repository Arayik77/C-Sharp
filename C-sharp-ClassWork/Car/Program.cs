namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opel opel = new Opel();
            opel.TestShofer();
            opel.TestCountry();

            Zafira zafira = new Zafira(true);
            //zafira.TestFarer();
            zafira.TestMator();

            Console.WriteLine(opel.Shofer + " shofer");
            Console.WriteLine(opel.Erkir + " country");
            Console.WriteLine(zafira.Farer + " farer");
            Console.WriteLine(zafira.Mator + " mator");
        }
    }
}