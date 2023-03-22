namespace CountryInterface
{
    internal class France : Icountry
    {
        public int population { get; set; } = 20000000;
        public byte factories { get; set; } = 10;
        public string capital { get; set; } = "Paris";
        public int size { get; set; } = 500000;

        public void FranceInfoCapital()
        {
            throw new NotImplementedException();
        }

        public void FranceInfoFactories()
        {
            throw new NotImplementedException();
        }

        public void FranceInfoPopulation()
        {
            throw new NotImplementedException();
        }

        public void FranceInfoSize()
        {
            throw new NotImplementedException();
        }
    }
}
