namespace Enum
{
    internal class Program
    {
        enum DayOfWeeks : byte
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum Color
        {
            green,
            white,
            red,
            black,
            yellow
        }
        static void Main(string[] args)
        {
            //ConsoleKey key = Console.ReadKey().Key;
            //int keyCode = (int)key;
            //Console.WriteLine($"Enum {key} Key Code {keyCode}");

            //if(key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("You press Enter");
            //}

            //DayOfWeek dayOfWeek = DayOfWeek.Tuesday;

            //Console.WriteLine(dayOfWeek);
            //Console.WriteLine((int)dayOfWeek);
            //Console.WriteLine((DayOfWeek)3);

            //DayOfWeek nextDay = GetNextDay(dayOfWeek);
            //Console.WriteLine(nextDay);



            //DayOfWeek dayOfWeek;
            //// int value = 55; // Invalid DayOfWeek value
            //int value = 2; // Tuesday

            //if (DayOfWeek.IsDefined(typeof(DayOfWeek), value))
            //{
            //    dayOfWeek = (DayOfWeek)value;
            //} else
            //{
            //    throw new Exception("Invalid DayOfWeek value");
            //}

            //Console.WriteLine(dayOfWeek);

            var values = Color.GetValues(typeof(Color));

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }

        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if(day < DayOfWeek.Saturday)
            {
                return day + 1;
            }

            return DayOfWeek.Monday;
        }
    }
}