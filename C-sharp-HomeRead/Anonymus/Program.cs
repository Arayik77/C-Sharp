namespace Anonymus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new { Name = "Tom", Age = 34 };
            var student = new { Name = "Tom2", Age = 342 };
            var manager = new { Name = "Tom3", Age = 343, Company = "Microsoft" };

            //Console.WriteLine(user.GetType().Name);
            //Console.WriteLine(student.GetType().Name);
            //Console.WriteLine(manager.GetType().Name);

            var people = new[]
            {
                new { Name = "Tom" },
                new { Name = "Bob" }
            };

            foreach(var p in people)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}