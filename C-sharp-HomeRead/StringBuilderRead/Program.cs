using System.Text;

namespace StringBuilderRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Jhon");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}