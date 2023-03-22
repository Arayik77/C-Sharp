namespace CodeSignal5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 4;
            int result = (t * t) + ((t - 1) * (t - 1));
            Console.WriteLine(result);

            //1 - 1
            //2 - 5    2 * 2 + 1
            //3 - 13   3 * 3 + 4
            //4 - 25   4 * 4 + 9
            //5 - 41   5 * 5 + 16
            //6 - 61   6 * 6 + 25
        }
    }
}