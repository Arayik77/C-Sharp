namespace OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product weight");
            int productWeight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter transportation type  \n1) AirPlane \n2) Truck \n3) Ship");
            int transportationType = Int32.Parse(Console.ReadLine());

            switch (transportationType) { 
                case 1:
                    AirPlane airPlane = new AirPlane();
                    airPlane.AirPlaneTransport(productWeight);
                    break;
                case 2:
                    Truck truck = new Truck();
                    truck.TruckTransport(productWeight);
                    break;
                case 3:
                    Ship ship = new Ship();
                    ship.ShipTransport(productWeight);
                    break;
                default: Console.WriteLine("Error");
                    break;
            }
            Console.Read();


        }
    }
}