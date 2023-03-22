using static DelegateProgram.DelegateClass;

namespace DelegateProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateClass delegateClass = new DelegateClass();
            ValuesDelegate valueDeledate = new ValuesDelegate(delegateClass.ReturnMethod1);
            //ValuesDelegate valueDeledate = null;
            valueDeledate += delegateClass.ReturnMethod1;
            valueDeledate += delegateClass.ReturnMethod2;
            valueDeledate += delegateClass.ReturnMethod3;
            valueDeledate += delegateClass.ReturnMethod3;

            valueDeledate("valod ");

        }
    }
}