namespace HummanApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humman humman = new Humman();

            // humman name

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            int hummanName = humman.PersonNameCount(name);
            bool hummanNameValidation = humman.PersonNameValidation(name);

            // humman surname

            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();
            int hummanSurname = humman.PersonSurnameCount(surname);
            bool hummanSurnameValidation = humman.PersonSurnameValidation(surname);

            // console humman name count / surname count

            Console.WriteLine($"Humman name count is {hummanName}");
            Console.WriteLine($"Humman surname count is {hummanSurname}");

            // console humman name validation / surname validation

            Console.WriteLine($"Humman name validation is {hummanNameValidation}");
            Console.WriteLine($"Humman surname validation is {hummanSurnameValidation}");
        }
    }
}