using System;

public class StartUp
{
    public static void Main()
    {
        var acc = new BankAccount
        {
            ID = 1,
            Balance = 15
        };

        Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
    }
}
