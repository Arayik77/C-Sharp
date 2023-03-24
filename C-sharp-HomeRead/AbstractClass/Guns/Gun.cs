namespace AbstractClass
{
    internal class Gun : Weapon
    {
        public override int Demage
        {
            get { return 5; }
        }

        public override void Fire()
        {
            Console.WriteLine("GunGmp!");
        }
    }
}
