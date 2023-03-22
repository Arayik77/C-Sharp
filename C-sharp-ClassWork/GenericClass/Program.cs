namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isBool = false;
            MyClass<string> myClass = new MyClass<string>();
            Console.WriteLine(myClass.Method1("asa", ref isBool) + " string");


            Console.WriteLine(isBool+" is my new bool");


            MyClass<bool> myClassBool = new MyClass<bool>();
            Console.WriteLine(myClassBool.Method2(isBool) + " bool");

        }
    }
}   