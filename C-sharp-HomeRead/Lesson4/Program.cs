namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "aabaa";
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string inputString1 = new string(charArray);
            if(inputString == inputString1)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }

        }
    }
}