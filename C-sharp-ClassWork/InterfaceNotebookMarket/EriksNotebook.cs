namespace InterfaceNotebookMarket
{
    internal class EriksNotebook : INotebook
    {
        public string Brand { get; set; } = "Aaa";
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public int count { get; set; }

        public void FirstAccelaration()
        {
            Console.WriteLine("Brand " + Brand);
            Console.WriteLine("EriksNotebook : INotebook : FirstAccelaration");
        }

        void INotebook.SecondAccelaration(int u)
        {
            Console.WriteLine("SecondAccelaration " + u);
        }
    }
}