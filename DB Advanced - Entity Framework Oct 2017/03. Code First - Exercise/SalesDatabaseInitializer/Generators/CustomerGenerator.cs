namespace SalesDatabaseInitializer.Generators
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using P03_SalesDatabase.Data.Models;

    internal class CustomerGenerator
    {
        private const string NamePath = @"../SalesDatabaseInitializer\Data\NamesData.txt";
        private const string CardNumberPath = @"../SalesDatabaseInitializer\Data\CardsNumbersData.txt";

        private static readonly string[] Domains = { "mail.bg", "abv.bg", "gmail.com", "hotmail.com", "softuni.bg", "students.softuni.bg" };
        private static readonly string[] CardNumbersData = File.ReadAllLines(CardNumberPath);
        private static readonly string[] NamesData = File.ReadAllLines(NamePath);
        private static readonly string[] EmailsData = new string[NamesData.Length];

        private static Random rnd = new Random();

        static CustomerGenerator()
        {
            GenerateEmails();
        }

        internal static IList<Customer> CustomersGenerator()
        {
            IList<Customer> customers = new List<Customer>();

            for (int i = 0; i < NamesData.Length; i++)
            {
                Customer customer = new Customer()
                {
                    Name = NamesData[i],
                    CreditCardNumber = CardNumbersData[CardNumbersData.Length % (i + 1)],
                    Email = EmailsData[i]
                };

                customers.Add(customer);
            }

            return customers;
        }

        private static void GenerateEmails()
        {
            for (int i = 0; i < NamesData.Length; i++)
            {
                EmailsData[i] = $"{ NamesData[i].ToLower()}{i}@{Domains[rnd.Next(0, Domains.Length)]}";
            }
        }
    }
}