namespace InterfaceNotebookMarket
{
    internal interface INotebook
    {
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        int count { get; set; }

        public void FirstAccelaration();

        public void SecondAccelaration(int t)
        {
            Console.WriteLine(t);
        }
    }
}
