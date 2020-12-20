using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(0, 100, true, "32312", "Super X", 4);
            AccountBoxWithState accountBox = new AccountBoxWithState();

            int dayCounter = 0;
            while (true)
            {
                dayCounter++;
                if (dayCounter < account.whenToPay )
                    Console.WriteLine("You don't need to pay, be happy:)");
                else
                {
                    account.TimeToPay();
                    dayCounter = 0;
                }
                
                account.CheckBalance();
                Console.WriteLine("Current plan cost: {0}", account.cashToPay);
                float sum = float.Parse(Console.ReadLine());
                if (sum <= 0)
                    break;
                account.AddBalance(sum);
                accountBox.State = account.CheckForBlocking();

                Console.WriteLine(accountBox.CheckAccountBlocking());
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}