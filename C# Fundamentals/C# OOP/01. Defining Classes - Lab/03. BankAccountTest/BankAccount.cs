using System;

namespace _03.BankAccountTest
{
    public class BankAccount
    {
        public BankAccount(int id)
        {
            this.ID = id;
        }

        private int id;
        private double balance;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }

                this.balance = value;
            }
        }

        public void Deposit(double amout)
        {
            this.Balance += amout;
        }

        public void WithDraw(double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.ID}, balance {this.Balance:F2}";
        }
    }
}
