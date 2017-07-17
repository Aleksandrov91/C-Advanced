namespace _03.BankAccountTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var bankAccounts = new Dictionary<int, BankAccount>();
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (inputData[0])
                {
                    case "Create":
                        CreateNewBankAccount(bankAccounts, int.Parse(inputData[1]));
                        break;
                    case "Deposit":
                        DepositToAccount(bankAccounts, int.Parse(inputData[1]), double.Parse(inputData[2]));
                        break;
                    case "Withdraw":
                        WithDrawFromAccount(bankAccounts, int.Parse(inputData[1]), double.Parse(inputData[2]));
                        break;
                    case "Print":
                        PrintAccountInfo(bankAccounts, int.Parse(inputData[1]));
                        break;
                }

                inputLine = Console.ReadLine();
            }
        }

        private static void PrintAccountInfo(Dictionary<int, BankAccount> bankAccounts, int id)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(bankAccounts.Where(a => a.Value.ID == id).FirstOrDefault().Value.ToString());
            }
        }

        private static void WithDrawFromAccount(Dictionary<int, BankAccount> bankAccounts, int id, double amount)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var wantedAccount = bankAccounts.Where(k => k.Value.ID == id).FirstOrDefault();
                if (wantedAccount.Value.Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    wantedAccount.Value.WithDraw(amount);
                }
            }
        }

        private static void DepositToAccount(Dictionary<int, BankAccount> bankAccounts, int id, double amount)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var wantedAccount = bankAccounts.Where(k => k.Value.ID == id).FirstOrDefault();
                wantedAccount.Value.Deposit(amount);
            }
        }

        private static void CreateNewBankAccount(Dictionary<int, BankAccount> bankAccounts, int id)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                bankAccounts[id] = new BankAccount(id);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}
