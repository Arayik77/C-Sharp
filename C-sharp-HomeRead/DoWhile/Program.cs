namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //{
            //    Console.WriteLine("Doing"); // Doing
            //}


            //do
            //{
            //    Console.WriteLine("Doing"); // Doing
            //} while (false);


            //int count = 5;

            //while(count < 5)
            //{
            //    count++;
            //    Console.WriteLine(count);  // nothing
            //}


            //int count = 5;

            //do
            //{
            //    count++;
            //    Console.WriteLine(count);  // 6
            //} while (count < 5);


            int count = 0;

            do
            {
                count++;
                Console.WriteLine(count);  // 1 2 3 4 5
            } while (count < 5);
            
        }
    }
}