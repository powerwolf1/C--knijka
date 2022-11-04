#nullable enable

class Program
{
    static void Main(string[] args)
    {
        // int thisCannotBeNull = 4;
        // thisCannotBeNull = null; // compile error

        int? thisCouldBeNull = null;
        Console.WriteLine(thisCouldBeNull);
        Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

        thisCouldBeNull = 7;
        Console.WriteLine(thisCouldBeNull);
        Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

        // if (thisCouldBeNull != null)
        // {
        //     // int length = thisCouldBeNull.Length; // could throw exception
        // }

        var adress = new Address();
        adress.Building = null;
        // adress.Street = null; // error (it can't be null)
        adress.City = "London";
        // adress.Region = null; // error (it can't be null)
    }
}

class Address
{
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;

}