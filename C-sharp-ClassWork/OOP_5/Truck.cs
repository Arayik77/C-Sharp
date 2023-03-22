namespace OOP_5
{
    internal class Truck : ITransPort
    {
        public int ShipingTime { get; set; } = 200;
        public int MinWeight { get; set; } = 0;
        public int MaxWeight { get; set; } = 10000;
        //public int CountryRestriction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void TruckTransport(int t)
        {
            if (t > MinWeight && t <= MaxWeight)
            {
                Console.WriteLine("Your deliver success");
                Console.WriteLine($"Your delivery truck time is {ShipingTime}");
            }
            else
            {
                Console.WriteLine("Your deliver rejected");
            }
        }
    }
}
