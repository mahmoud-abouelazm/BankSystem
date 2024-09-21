namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter details for Saving Account(Holder , Balance)");
                SavingAccount sav = new(Console.ReadLine() , Convert.ToInt32(Console.ReadLine()));

                //Console.WriteLine("Enter details for Checking Account(Holder , Balance)");
                //CheckingAccount chek = new(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

                //Console.WriteLine("Enter details for Investment Account(Holder , Balance)");
                //InvestmentAccount inv = new(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

                //Console.WriteLine("Enter details for Credit Account(Holder , Balance)");
                //CreditAccount cri = new(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()) , Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine($"Account type : SavingAccount");
                Console.WriteLine($"Account holder {sav.AccountHolderName}");
                Console.WriteLine(sav.AccountNumber);
                Console.WriteLine($"{sav.CheckBalance():C}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
