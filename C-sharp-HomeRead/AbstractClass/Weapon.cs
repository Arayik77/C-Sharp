namespace AbstractClass
{
    abstract class Weapon
    {
        public abstract int Demage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Demage: {Demage}");
        }

    }
}
