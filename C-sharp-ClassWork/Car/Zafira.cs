namespace Car
{
    internal class Zafira:Opel
    {

        public bool quansh;
        public void TestMator()
        {
            Mator = MatorType.mekukesnoc;
        }
        public void TestFarer()
        {
            Farer = false;
        }

        public Zafira() : base() {

        }

        public Zafira(bool t) : base(t)
        {
            quansh = t;
        }
    }
}
