namespace AbstractClass
{
    internal class Bow : Weapon
    {
        public override int Demage => 10;

        public override void Fire()
        {
            Console.WriteLine("GmpBow!");
        }
    }
}
