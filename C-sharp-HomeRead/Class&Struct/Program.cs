namespace Class_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();
            //int result = myClass.Sum(10, 20);
            int result = MyClass.Sum(10, 20);
            Console.WriteLine(result);

            Structuries structuries = new Structuries();
            int resultSruct = structuries.Sum(20, 30);
            Console.WriteLine(resultSruct);
        }
    }
}