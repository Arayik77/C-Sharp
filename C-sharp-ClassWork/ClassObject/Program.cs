namespace ClassObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceQyabab = 1000;
            int priceShaurma = 1500;
            int quantuity = 15;

            //Meat meatTotal = new Meat();
            //Meat meatTotal1 = new Meat(priceShaurma, quantuity);
            //Meat meatTotal2 = new Meat(priceShaurma, priceQyabab, quantuity);


            int shaurmaTotal = Meat.Shaurma(priceShaurma, quantuity);
            int shaurmaTotal1 = Meat.Shaurma1(priceShaurma, quantuity);
            int qyababTotal = Meat.Qyabab(priceQyabab, quantuity);
            int qyababTotal1 = Meat.Shaurma1(priceQyabab, quantuity);

            Console.WriteLine(shaurmaTotal);
            Console.WriteLine(shaurmaTotal1);
            Console.WriteLine(qyababTotal);
            Console.WriteLine(qyababTotal1);
        }
    }
}