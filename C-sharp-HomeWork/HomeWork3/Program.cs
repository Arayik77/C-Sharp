namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 7;
            int c = 21;
            int d = 40;

            int threeDigits = 123;
            int threeDigitsFirst = threeDigits % 10;
            int threeDigitsSecond = ((threeDigits - threeDigitsFirst) / 10) % 10;
            int threeDigitsThreed = (((threeDigits - threeDigitsFirst) / 10) - threeDigitsSecond) / 10;
            bool t = false;

            // 21

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c);
            }

            // 22

            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c);
            }

            // 23

            if (a == b || a == c || b == c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // 24

            if (a + b == 2 || a + c == 2 || b + c == 2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // 25

            if (a + b > c || a + c > b || b + c > a)
            {
                Console.WriteLine("y=1");
            }
            else
            {
                Console.WriteLine("y=2");
            }

            // 26

            if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }

            // 27

            if (b - a == c - b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // 28

            if (b / a == c / a)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // 29

            if (a > b && b > c)
            {
                Console.WriteLine($"{a},{b},{c}");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine($"{b},{a},{c}");
            }
            else if (c > a && a > b)
            {
                Console.WriteLine($"{c},{a},{b}");
            }


            // 30

            if (a < b && b < c)
            {
                Console.WriteLine($"{c},{b},{a}");
            }
            else if (b < a && a < c)
            {
                Console.WriteLine($"{c},{a},{b}");
            }
            else if (c < a && a < b)
            {
                Console.WriteLine($"{b},{a},{c}");
            }

            // 31

            if (a > b && a > c && a > d)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(d);
            }

            // 32

            if (a < b && a < c && a < d)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c && b < d)
            {
                Console.WriteLine(b);
            }
            else if (c < a && c < b && c < d)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(d);
            }

            // 33

            if (a == b || a == c || a == d || b == c || b == d || c == d)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // 34

            if (a + b == c + d || a + c == b + d || a + d == b + c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // 35

            if (a == b + c + d || b == a + c + d || c == a + b + d || d == a + b + c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // 36

            if (a % 2 != 0 || b % 2 != 0 || c % 2 != 0 || d % 2 != 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }


            // 51

            if (threeDigitsFirst == threeDigitsSecond + threeDigitsThreed)
            {
                t = true;
            } else
            {
                t = false;
            }

            Console.WriteLine(t);
        }
    }
}