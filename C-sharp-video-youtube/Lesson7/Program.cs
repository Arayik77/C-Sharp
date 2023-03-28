namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5";
            int number = int.Parse(str);
            Console.WriteLine(number);

            string str1 = "5.9";
            double number1 = double.Parse(str1);
            Console.WriteLine(number1);

            string str2 = "7dfgdfgdf";
            // int number2 = Convert.ToInt32(str2);
            // Console.WriteLine(number2); // error

            try
            {
                int number3 = int.Parse(str2);
                Console.WriteLine($"number 3 is {number3}");
            } catch (Exception ex)
            {
                Console.WriteLine("not a correct info");
            }
        }
    }
}