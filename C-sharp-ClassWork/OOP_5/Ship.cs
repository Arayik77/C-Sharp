namespace OOP_5
{
    internal class Ship : ITransPort
    {
        public int ShipingTime { get; set; } = 200;
        public int MinWeight { get; set; } = 20000;
        public int MaxWeight { get; set; } = 50000;
        //public int CountryRestriction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShipTransport(int t)
        {
            if (t > MinWeight && t <= MaxWeight)
            {
                Console.WriteLine("Your deliver success");
                Console.WriteLine($"Your delivery ship time is {ShipingTime}");
            }
            else
            {
                AirPlane truck = new AirPlane();
                truck.AirPlaneTransport(t);
            }
        }
    }
}
