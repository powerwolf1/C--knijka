namespace Packt.Shared
{
    public class BankAccount
    {
        public string AccountName = string.Empty; // instance member

        public decimal Balance; // instance member

        public static decimal InterestRate; // shared member


    }
}