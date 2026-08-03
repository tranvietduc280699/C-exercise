using lesson4.Model;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Account acc = new Account();
            acc.Deposit(500000);
            acc.WithDraw(300000);

            SavingAccount saving = new SavingAccount(2000m, 0.05m);
            CheckAccount check = new CheckAccount(1000, 10000);
            check.Deposit(32000);
            check.WithDraw(200000);


        }
    }
}
