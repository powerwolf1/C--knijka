using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            WriteLine($"a & DoStuff() = {a && DoStuff()}");
            WriteLine($"b & DoStuff() = {b && DoStuff()}");
        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff");
            return true;
        }
    }
}