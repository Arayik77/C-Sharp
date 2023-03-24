namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor start

            Person person = new Person("Test", "Testyan");
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.ShortName);
            Console.ReadLine();

            // constructor end


            //Person person = new Person();
            //person.FirstName = "Test";
            //person.SecondName = "Testyan";
            //Console.WriteLine(person.FullName);
            //Console.WriteLine(person.ShortName);
            //Console.ReadLine();

            //person.SetName("Test");
            //Console.WriteLine(person.GetName());
            //Console.ReadLine(); // Person class i meji comment i hamar er sa

            // person.Name = "Test"; // public linelu jamanak
        }
    }
}