namespace Var
{
    class Person
    {

    }
    internal class Program
    {
        static int age = 100;

        static int Sum(int a, int b)
        {
            var result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            //int value = 100;
            //var value1 = 100;

            //int a = 10;
            //Console.WriteLine(a.GetType());

            // var person = new Person(); // Person person = new Person();

            //var value = "sdsdfsdf";
            //Console.WriteLine(value);

            //Console.WriteLine(age);

            Console.WriteLine(Sum(10, 20));

        }
    }
}