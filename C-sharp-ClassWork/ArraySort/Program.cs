namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortInt = new int[100];
            for (int i = 0; i < sortInt.Length; i++)
                sortInt[i] = i;
                Console.WriteLine(string.Join(",", sortInt));


            int x = Convert.ToInt32(Console.ReadLine());
            int srtlng = sortInt.Length;
            for (int i = 0; i < srtlng;)
            {
                if (i == x)
                {
                    Console.WriteLine("true");
                    Console.WriteLine(i);
                    break;
                }
                i++;
                if (x >= (i + srtlng) / 2)
                    i = (srtlng + i) / 2;
                else
                    srtlng = (i + srtlng) / 2;
            }
        }
    }
}