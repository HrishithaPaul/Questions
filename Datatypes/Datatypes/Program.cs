namespace Assignment6.Datatypes
{
    public class Program
    {
        private static string intValue;
        private static string floatValue;
        private static string doubleValue;
        private static string longValue;
        private static string str;

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value");
            intValue = Console.ReadLine();
            Console.WriteLine("Enter a float value");
            floatValue = Console.ReadLine();
            Console.WriteLine("Enter a double value");
            doubleValue = Console.ReadLine();
            Console.WriteLine("Enter a long value");
            longValue = Console.ReadLine();
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            Displayoutput();
        }

        public static void Displayoutput()
        {
            Console.WriteLine("int: " + intValue);
            Console.WriteLine("float: " + floatValue);
            Console.WriteLine("double: " + doubleValue);
            Console.WriteLine("long: " + longValue);
            Console.WriteLine("string: " + str);
        }
    }
}
