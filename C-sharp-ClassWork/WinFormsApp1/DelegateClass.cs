namespace WinFormsApp1
{
    public class DelegateClass
    {
        public delegate string ValuesDelegate(int a);

        public int Method1()
        {
            int i = 5;
            return i + 3;
        }
        public int Method2()
        {
            int i = 5;
            return i + 2;
        }

        public int Method3()
        {
            int i = 5;
            return i + 7;
        }
    }
}
