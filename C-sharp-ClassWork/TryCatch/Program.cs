namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myArray = { 1, 2, 3 };
                Console.WriteLine(myArray[10]);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finnaly");
            }
        }
    }
}