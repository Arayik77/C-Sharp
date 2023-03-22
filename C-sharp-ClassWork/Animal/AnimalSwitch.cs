namespace Animal
{
    internal class AnimalSwitch
    {
        public virtual string AnimalVoice(AnimalEnumType animalName)
        {

            //switch(animalName)
            //{
            //    case AnimalEnumType.Dog:
            //        return 
            //}

            //Console.WriteLine("sss");
            //return animal;
        }

        public virtual string AnimalSpeed(string animal)
        {
            Console.WriteLine("aaa");
            return animal;
        }

    }

    public enum AnimalEnumType
    {
        Cat,
        Dog,
        Lion
    }
}
