namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Enter 'deposit' to add funds to your account or 'balance' to see your balance");
            string response = Console.ReadLine();

            if (response == "deposit")
            {
                Console.WriteLine("Enter deposit amount in numbers only");
                string deposit = Console.ReadLine();
                account.Deposit(double.Parse(deposit));
            }
            else if (response == "balance")
            {
                Console.WriteLine(account.GetBalance());
            }
            else {
                Console.WriteLine("Request not recognized");
            }
        }
    }
}
