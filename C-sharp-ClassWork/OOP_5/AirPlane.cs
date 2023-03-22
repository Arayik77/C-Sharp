namespace OOP_5
{
    internal class AirPlane : ITransPort
    {
        public int ShipingTime { get; set; } = 10;
        public int MinWeight { get; set; } = 10000;
        public int MaxWeight { get; set; } = 20000;
        //public int CountryRestriction { get; set; }

        public void AirPlaneTransport(int t)
        {
            if(t > MinWeight && t <= MaxWeight)
            {
                Console.WriteLine("Your deliver success");
                Console.WriteLine($"Your delivery airplane time is {ShipingTime}");
            } else
            {
                Truck truck = new Truck();
                truck.TruckTransport(t);
            }
        }
    }
}
