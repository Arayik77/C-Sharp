namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(120, "John"));
            animals.Add(new Cat(210, "Alex"));
            animals.Add(new Dog(50, "Margarit"));

            foreach (Animal animal in animals)
            {
                animal.Print();
            }

            Console.ReadKey();
        }
    }
}