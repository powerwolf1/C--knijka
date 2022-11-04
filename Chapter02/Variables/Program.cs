using System.IO;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        // object height = 1.88;
        // object name = "Amir";
        // Console.WriteLine($"{name} is {height} metres tall.");

        // // int length1 = name.Length;
        // int length2 = ((string)name).Length;
        // Console.WriteLine($"{name} has {length2} characters.");

        // dynamic anotherName = "Ahmed";

        // int length = anotherName.Length;

        // var xml = new XmlDocument();
        // XmlDocument xml2 = new XmlDocument();

        Console.WriteLine($"default(int) {default(int)}");
        Console.WriteLine($"default(string) {default(string)}");
        Console.WriteLine($"default(DateTime) {default(DateTime)}");
        Console.WriteLine($"default(bool) {default(bool)}");

    }
}