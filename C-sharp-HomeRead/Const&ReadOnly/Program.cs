namespace Const_ReadOnly
{
    internal class Program
    {

        class MyClass
        {
            public const double PI = 3.14;

            public const string MY_ERROR = "Error";

            public readonly int _b;
            public static readonly int _c;

            public MyClass(int a)
            {
                //PI = 3; // we cann't change constant
                _b = a;
            }

            public void Foo()
            {
                // MY_ERROR = "New Error"; // we cann't change constant

                Console.WriteLine(MY_ERROR);
                Console.WriteLine(_b);
            }
        }

        static void Main(string[] args)
        {
            // MyClass.MY_ERROR = "New Error"; // we cann't change constant
            
            MyClass myClass = new MyClass(10);
            myClass.Foo();
        }
    }
}