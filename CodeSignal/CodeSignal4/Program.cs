namespace CodeSignal4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 6, -2, -5, 7, 3 };

            int mylargestSum = myArray[0] * myArray[1];

            for(int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] != myArray[myArray.Length - 1])
                {
                    int myLargestSum1 = myArray[i] * myArray[i + 1];
                    if (mylargestSum < myLargestSum1)
                    {
                        mylargestSum = myLargestSum1;
                    }
                }
            }
            Console.WriteLine(mylargestSum);


        }
    }
}