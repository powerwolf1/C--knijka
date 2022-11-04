using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // string password = string.Empty;
        // int i = 0;

        // do
        // {
        //     Write("Enter hui");
        //     password = ReadLine();
        //     i += 1;
        // }
        // while (password != "Password" && i < 10);

        // WriteLine("Correct!");

        // byte[] binaryObject = new byte[128];

        // (new Random()).NextBytes(binaryObject);

        // WriteLine("Binary Object as bytes.");

        // for (int index = 0; index < binaryObject.Length; index++)
        // {
        //     Write($"{binaryObject[index]:X} ");
        // }
        // WriteLine();

        // string encoded = Convert.ToBase64String(binaryObject);

        // WriteLine($"Binary object as Base64: {encoded}");

        // int age = int.Parse("27");
        // DateTime birthday = DateTime.Parse("4 July 1980");

        // WriteLine($"I was born {age} years ago.");
        // WriteLine($"My birthday is {birthday}");
        // WriteLine($"My birthday is {birthday:D}");

        Write("How many eggs are there?");
        int count;
        string input = ReadLine();

        if (int.TryParse(input, out count))
        {
            WriteLine($"there are {count} eggs");
        }
        else
        {
            WriteLine("I could not parse the input");
        }
    }
}