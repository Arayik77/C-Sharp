namespace OOP_5
{
    internal interface ITransPort
    {
        public int ShipingTime { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
        //public int CountryRestriction { get; set; } // enum
    }
}
