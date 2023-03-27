namespace Animals
{
    internal class Dog : Animal
    {
        private int speed;
        public Dog(int speed, string name) : base(name)
        {
            this.speed = speed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Dog speed: {speed}");
        }
    }
}
