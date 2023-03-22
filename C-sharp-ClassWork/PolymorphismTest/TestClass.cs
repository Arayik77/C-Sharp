namespace PolymorphismTest
{
    internal class TestClass: VirtualClass
    {
        public override void VirtualEmpthyMethod()
        {
            Console.WriteLine("TestClass: VirtualClass");
            base.VirtualEmpthyMethod();
            Console.WriteLine("Ending VirtualEmpthyMethod");
        }

        public override int VirtualMethod(int u)
        {
            return base.VirtualMethod(u);
        }

        public TestClass(int t)
        {
            base.VirtualMethod(t);
        }

        public TestClass()
        {
            
        }
    }
}
