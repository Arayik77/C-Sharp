namespace InterfaceNotebookMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EriksNotebook eriksNotebook = new EriksNotebook();
            eriksNotebook.FirstAccelaration();

            INotebook notebook = new EriksNotebook();
            notebook.SecondAccelaration(10);
        }
    }
}