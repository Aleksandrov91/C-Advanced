using System;

public class BankAccount
{
    private int id;
    private double balance;

    public int ID
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public double Balance
    {
        get
        {
            return this.balance;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Balance cannot be negative");
            }

            this.balance = value;
        }
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.balance -= amount;
    }
}
