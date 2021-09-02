using System;

namespace Polymorphism1
{
    public class Account
    {
        private double balance;

        private double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double amount)
        {
            if (amount > 0)
                balance = +amount;
            else
                Console.WriteLine("please pass +ve value");
        }
        public void BalanceDetails()
        {
            Console.WriteLine("Account Balance=" + balance);
        }
    }
}
