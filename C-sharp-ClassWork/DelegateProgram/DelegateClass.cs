namespace DelegateProgram
{
    internal class DelegateClass
    {
        public delegate string ValuesDelegate(string a);

        public string ReturnMethod1(string a)
        {
            Console.WriteLine(a + "1");
            return a;
        }

        public string ReturnMethod2(string a)
        {
            Console.WriteLine(a + "2");
            return a;
        }

        public string ReturnMethod3(string a)
        {
            Console.WriteLine(a + "3");
            return a;
        }

    }
}
