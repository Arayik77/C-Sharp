namespace StaticClass
{
    internal class Program
    {

        class MyClass
        {
            public static int b;

            public void SetB(int b)
            {
                MyClass.b = b;
            }

            public void PrinyB()
            {
                Console.WriteLine(b);
            }
        }
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.SetB(10);

            MyClass myClass2 = new MyClass();
            myClass2.PrinyB();
        }
    }
}