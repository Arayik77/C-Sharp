namespace StaticProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            string s = AA(a,b);
            Console.WriteLine(s);

            static string AA(string a, int b)
            {
                string c;
                for(int i =  0; i < b; i++)
                {
                    c += a;
                }

                return c;
            }
        }
    }
}