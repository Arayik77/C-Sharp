namespace Dynamic
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public override string ToString()
            {
                return Name + ". " + Age.ToString();
            }
        }
        static void Main(string[] args)
        {
            dynamic x = 3;
            Console.WriteLine(x);
            x = "Hello";
            Console.WriteLine(x);

            x = new Person() { Name = "Tom", Age = 23 };
            Console.WriteLine($"{x} {x.Name} {x.Age}");
            Console.WriteLine(x);
            Console.Read();
        }

    }
}