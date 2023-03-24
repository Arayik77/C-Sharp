namespace Polimorphism
{

    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("I drove!");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class SportCar : Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("Ran Ran Ran");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("I drove very smart!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Person person = new Person();
            //person.Drive(car); // myus dzevy taky

            Person person = new Person();
            //person.Drive(new Car());
            person.Drive(new SportCar());
        }
    }
}