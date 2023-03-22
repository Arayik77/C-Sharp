namespace EmptyArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray;
            //myArray = new int[5];
            //myArray[1] = 3;
            //myArray[0] = 10;
            //int a = myArray[0];
            //Console.ReadLine();

            // int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };

            // without methods

            // max

            //int myMaxValue = myArray[0];
            //for(int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > myMaxValue)
            //    {
            //        myMaxValue = myArray[i];
            //    }
            //}

            //Console.WriteLine(myMaxValue);

            // min

            //int myMinValue = myArray[0];
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] < myMinValue)
            //    {
            //        myMinValue = myArray[i];
            //    }
            //}

            //Console.WriteLine(myMinValue);

            // with method

            //int resultMax = myArray.Max();
            //Console.WriteLine(resultMax); // 111

            //int resultMin = myArray.Min();
            //Console.WriteLine(resultMin); // 4

            //int resultSum = myArray.Sum();
            //Console.WriteLine(resultSum); // 465

            //int resultWhere = myArray.Where(i => i < 10).Sum();
            //Console.WriteLine(resultWhere); // 13

            int[] myArray1 = { 111, 10, 4, 10, 111, 64, 77, 4, 42, 5 };

            int[] resultDistinct = myArray1.Distinct().ToArray();
            Console.WriteLine(resultDistinct); // { 111, 10, 4, 64, 77, 42, 5 }

            int[] resultOrderBy = myArray1.OrderBy(i => i).ToArray();
            Console.WriteLine(resultOrderBy); // { 4, 4, 5, 10, 10, 42, 64, 77, 111, 111 }
            
            int[] resultOrderByDescending = myArray1.OrderByDescending(i => i).ToArray();
            Console.WriteLine(resultOrderByDescending); // { 111, 111, 77, 64, 42, 10, 10, 5, 4, 4 }

            int resultFind = Array.Find(myArray1, i => i < 70);
            Console.WriteLine(resultFind); // 10

            int resultFindLast = Array.FindLast(myArray1, i => i < 70);
            Console.WriteLine(resultFindLast); // 5

            int[] resultFindAll = Array.FindAll(myArray1, i => i < 70);
            Console.WriteLine(resultFindAll); // { 10, 4, 10, 64, 4, 42, 5 }

            int resultIndex = Array.FindIndex(myArray1, i => i == 77);
            Console.WriteLine(resultIndex); // 6

            int resultIndexLast = Array.FindLastIndex(myArray1, i => i == 111);
            Console.WriteLine(resultIndexLast); // 4

            //int[] resultReverse = Array.Reverse(myArray1);
            //Console.WriteLine(resultReverse);

            int resultFirst = myArray1.Where(i => i < 70).First();
            Console.WriteLine(resultFirst); // 10

            int resultFirstOrDefault = myArray1.Where(i => i < 70).FirstOrDefault();
            Console.WriteLine(resultFirstOrDefault); // 10

            Console.ReadLine();
        }
    }
}