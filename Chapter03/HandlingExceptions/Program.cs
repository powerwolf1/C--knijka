using static System.Console;

class Programm
{
    static void Main(string[] args)
    {
        // WriteLine("Before parsing");
        // Write("What is your age?");

        // string input = ReadLine();

        // try
        // {
        //     int age = int.Parse(input);
        //     WriteLine($"You are {age} years old.");
        // }
        // catch (FormatException)
        // {
        //     WriteLine("The age you entered is not a valid number format.");
        // }
        // catch (OverflowException)
        // {
        //     WriteLine("Your age is a valid number format but it is either too big or small.");
        // }
        // catch (Exception ex)
        // {
        //     WriteLine($"{ex.GetType()} says {ex.Message}");
        // }

        // WriteLine("after parsing.");


        try
        {
            checked
            {
                int x = int.MaxValue - 1;
                WriteLine($"initial value: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
            }
        }
        catch (OverflowException)
        {
            WriteLine("the code overasdas");
        }

        unchecked
        {
            int y = int.MaxValue + 1;
            WriteLine($"Initial value: {y}");
            y--;
            WriteLine($"After decrementing: {y}");
            y--;
            WriteLine($"After decrementing: {y}");
        }
    }
}