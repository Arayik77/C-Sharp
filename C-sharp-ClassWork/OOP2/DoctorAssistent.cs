namespace OOP2
{
    internal class DoctorAssistent:Doctor
    {
        public void _DoctorAssist()
        {
            Console.WriteLine(Name);
        }
        public short AssistantAge { get; set; }

        public DoctorAssistent()
        {
            
        }
    }
}
