namespace CodeSignal7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 0, -2, 5, 6 };

            int k = myArray[0];
            bool t = false;
            for (int i = 1; i < myArray.Length; i++)
            {
                if (k + 1 == myArray[i])
                {
                    t = true;
                    k = myArray[i]; // Aro12345
                }
                else
                {
                    int numToRemove;
                    if (k > myArray[i])
                    {
                        numToRemove = k;
                    } else
                    {
                        numToRemove = myArray[i];
                    }
                    int numIndex = Array.IndexOf(myArray, numToRemove);
                    myArray = myArray.Where((val, idx) => idx != numIndex).ToArray();
                    break;
                }
            }

            Console.WriteLine(t);
            Console.WriteLine(myArray);

            int j = myArray[0];

            for (int l = 1; l < myArray.Length; l++)
            {
                if (j + 1 == myArray[l])
                {
                    t = true;
                    j = myArray[l];
                }
                else
                {
                    t = false;
                    break;
                }
            }

            Console.WriteLine($"erkrord angam {t}");
        }
    }
}