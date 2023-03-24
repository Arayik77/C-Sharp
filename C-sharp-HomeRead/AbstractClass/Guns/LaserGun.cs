namespace AbstractClass
{
    internal class LaserGun : Weapon
    {
        public override int Demage => 3;

        public override void Fire()
        {
            Console.WriteLine("GmpLaser!");
        }
    }
}
