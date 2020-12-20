using System;

namespace State
{
    public class Account
    {
        public float currentBalance;
        public float cashToPay;

        public bool isBlocked;
        public string number;
        public string plan;
        public int whenToPay;
        
        public Account(float currentBalance, float cashToPay, bool isBlocked, string number, string plan, int whenToPay)
        {
            this.currentBalance = currentBalance;
            this.cashToPay = cashToPay;
            this.isBlocked = isBlocked;
            this.number = number;
            this.plan = plan;
            this.whenToPay = whenToPay;
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your balance is: {0}", currentBalance);
        }

        public string CheckForBlocking()
        {
            if (isBlocked)
                return "BLOCKED";
            else
                return "WORKING";
        }

        
        public void AddBalance(float balance)
        {
            currentBalance += balance;
            if (currentBalance >= cashToPay)
                isBlocked = false;
        }

        public void TimeToPay()
        {
            
            float newBalance = currentBalance - cashToPay;
            if (newBalance < cashToPay)
            {
                Console.WriteLine("Not enough money.");
                isBlocked = true;
            }
            else
                Console.WriteLine("Enough money, you can continue speaking!");

            currentBalance = newBalance;
            if (isBlocked)
                Console.WriteLine("Your account blocked.");

        }
    }
    
}