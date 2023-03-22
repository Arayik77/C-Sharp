namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doctor doctor = new Doctor();
            //doctor.Testmethod();
            //Console.WriteLine(doctor.Age+ " Doctor");
            //Human human = new Human();
            //Console.WriteLine(human.Age+ " Human");

            //------------------------------------------

            Doctor doctorParam = new Doctor(8);
            doctorParam.Testmethod();
            Console.WriteLine(doctorParam.Age + " Doctor");
            Human humanBaseParam = new Human();
            Console.WriteLine(humanBaseParam.Age + " Human");
        }
    }
}