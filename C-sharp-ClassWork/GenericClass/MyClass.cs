namespace GenericClass
{
    internal class MyClass<T>
    {
        //public T myVal { get; set; }
        //public T myBool { get; set; } = false;
        public T Method1(T myString, ref bool isBool) {
            //myVal = myString;
            if (myString is string) {
                isBool = true;
            } else
            {
                isBool = false;
            }

            return myString;
        }

        public T Method2(T isBool) {
            if(isBool is true)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NO");
            }
            return isBool;
        }

    }
}
