namespace CountryInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            France france = new France();
            france.FranceInfoPopulation();

            Icountry icountry = new France();
            icountry.FranceInfoPopulation();
            icountry.FranceInfoFactories();
            icountry.FranceInfoCapital();
            icountry.FranceInfoSize();
        }
    }
}