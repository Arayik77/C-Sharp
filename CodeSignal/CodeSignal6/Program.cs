namespace CodeSignal6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] statues = { 6, 2, 3, 8, 10 };
            //int[] statues = { 0, 3 };
            int[] statues = { 5, 4, 6 };
            int count = 0;
            int minStatues = statues[0];
            int maxStatues = statues[0];

            for (int i = 1; i < statues.Length; i++)
            {
                if(statues[i] < minStatues)
                {
                    minStatues = (int)statues[i];
                }

                if (statues[i] > maxStatues)
                {
                    maxStatues = (int)statues[i];
                }
            }

            for (int j = minStatues; j <= maxStatues; j++)
            {
                if (!statues.Contains(j))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}