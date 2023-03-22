namespace OOP_5
{
    internal interface IDelivery
    {
        public long TrackingId { get; set; } // random readonly
        public string ShipingTime { get; set; } // delivery time
        public int ShipCoast { get; set; } // price
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int Sale { get; set; }
    }
}
