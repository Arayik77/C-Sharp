namespace HatukSoluition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant rest4581; // uxxaki haytararutyun
            Restaurant rest = new Restaurant(); // sarquma instance default ctor ogtvelov
            Restaurant rest2 = new Restaurant(66); // sarquma instance poxancelov ctor in 66 tivn

            // rest4581.t = 85;
            Console.WriteLine(rest.t); // default 0
            Console.WriteLine(rest2.MakeFood(Menu.Pizza, 7));

            Console.WriteLine(rest2.t); // 66
            Console.WriteLine(rest2.MakeFood(Menu.HotDog, 5));
        }
    }
}