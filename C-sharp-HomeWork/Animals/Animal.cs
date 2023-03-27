namespace Animals
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Animal {Name}");
        }
    }
}
