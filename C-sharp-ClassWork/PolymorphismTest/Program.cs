namespace PolymorphismTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestClass testClass = new TestClass(89);
            TestClass testClass2 = new TestClass();
            testClass2.NormalMethod();
            testClass2.VirtualEmpthyMethod();
            testClass2.VirtualVoidMethod();
            testClass2.VirtualMethod(65);
        }
    }
}