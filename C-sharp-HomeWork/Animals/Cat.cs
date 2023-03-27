namespace Animals
{
    internal class Cat : Animal
    {
        private int speed;
        public Cat(int speed, string name) : base(name)
        {
            this.speed = speed;
        }

        public override void Print()
        {
            Console.WriteLine($"Cat speed: {speed}");
        }
    }
}
