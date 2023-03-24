namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //Gun gun = new Gun();
            //player.Fire(gun);

            Weapon[] inverntory = { new Gun(), new LaserGun(), new Bow() };

            foreach (var item in inverntory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
    }
}