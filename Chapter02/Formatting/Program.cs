using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int numberOfApples = 12;
        decimal pricePerApple = 0.35M;

        WriteLine(
            format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples
        );

        string formatted = string.Format(
            format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples
        );

        // Write("Type your first name and press ENTER");
        // string firstName = ReadLine();

        // Write("Typer your age and press Enter");
        // string age = ReadLine();

        // WriteLine($"Hello {firstName}, you look good for {age}");

        Write("Press any key combination: ");
        ConsoleKeyInfo key = ReadKey();
        WriteLine();
        WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                    arg0: key.Key,
                    arg1: key.KeyChar,
                    arg2: key.Modifiers);
    }
}