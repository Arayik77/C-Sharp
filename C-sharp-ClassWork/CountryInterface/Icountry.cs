namespace CountryInterface
{
    internal interface Icountry
    {
        public int population { get; set; }
        public byte factories { get; set; }
        public string capital { get; set; }
        public int size { get; set; }

        public void FranceInfoPopulation();
        public void FranceInfoFactories();
        public void FranceInfoCapital();
        public void FranceInfoSize();

    }
}
