namespace OOP2
{
    internal class Doctor:Human
    {
        public short y;
        public void Testmethod()
        {
            Name = "Elizaveta Vachaganovna";
            Age = y;
            //publicHelloMen();
            //internalByMen();
            //protectedWhyMen();
            //_privateWhyMen()
        }
        public Doctor() : base()
        {
        }
        public Doctor(short t) : base(t)
        {
            this.y = t;
        }
    }
}
