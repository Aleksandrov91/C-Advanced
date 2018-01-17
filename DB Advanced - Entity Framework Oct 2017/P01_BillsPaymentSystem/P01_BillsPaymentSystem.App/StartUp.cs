namespace P01_BillsPaymentSystem.App
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Storage;
    using System.Linq;
    using Data;
    using Data.Models;
    using Data.Models.Enums;
    using Data.Models.ViewModels;

    public class StartUp
    {
        public static void Main()
        {
            MappingConfig.RegisterMaps();

            using (BillsPaymentSystemContext context = new BillsPaymentSystemContext())
            {
                bool isDbExist = (context.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists();

                if (!isDbExist)
                {
                    ResetDatabase(context);
                    SeedData(context);
                }

                Console.WriteLine("Select Option:");
                Console.WriteLine("1 - Get user information");
                Console.WriteLine("2 - Pay bills");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("Please enter User Id:");
                    int userId = int.Parse(Console.ReadLine());

                    Console.WriteLine(GetUserData(context, userId));
                }
                else if (option == 2)
                {
                    Console.Write("Please enter User Id:");
                    int userId = int.Parse(Console.ReadLine());

                    Console.Write("Bills amount:");
                    decimal billsAmount = decimal.Parse(Console.ReadLine());

                    Console.WriteLine(PayBills(userId, billsAmount, context));
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                    return;
                }
            }
        }

        private static User GetUserById(int userId, BillsPaymentSystemContext context)
        {
            User user = context.Users
                .Include(u => u.PaymentMethods)
                .ThenInclude(ub => ub.BankAccount)
                .Include(u => u.PaymentMethods)
                .ThenInclude(ub => ub.CreditCard)
                .Where(u => u.UserId == userId)
                .SingleOrDefault();

            return user;
        }

        private static string PayBills(int userId, decimal amount, BillsPaymentSystemContext context)
        {
            User user = GetUserById(userId, context);

            if (user == null)
            {
                return $"User with id {userId} not found!";
            }

            UserViewModel usermodel = AutoMapper.Mapper.Map<User, UserViewModel>(user);

            string billsMessage = usermodel.PayBills(amount);
            User modifiedUser = AutoMapper.Mapper.Map<UserViewModel, User>(usermodel);

            context.Attach(modifiedUser);

            context.Entry(modifiedUser).State = EntityState.Modified;

            context.UpdateRange(modifiedUser);

            context.SaveChanges();

            return billsMessage;
        }

        private static string GetUserData(BillsPaymentSystemContext context, int userId)
        {
            User user = GetUserById(userId, context);

            if (user == null)
            {
                return $"User with id {userId} not found!";
            }

            UserViewModel usermodel = AutoMapper.Mapper.Map<User, UserViewModel>(user);

            return usermodel.ToString();
        }

        private static void SeedData(BillsPaymentSystemContext context)
        {
            User[] users = new[]
            {
                new User()
                {
                    FirstName = "Georgi",
                    LastName = "Georgiev",
                    Email = "georgi.georgiev@abv.bg",
                    Password = "gosho123"
                },
                new User()
                {
                    FirstName = "Ivan",
                    LastName = "Petkov",
                    Email = "i.petkov@gmail.com",
                    Password = "nqmadatikaja"
                },
                new User()
                {
                    FirstName = "Hrisofor",
                    LastName = "Haralambiev",
                    Email = "h.h_golemiqtpich@abv.bg",
                    Password = "mnogosymgotin"
                },
                new User()
                {
                    FirstName = "Jordan",
                    LastName = "Ivanov",
                    Email = "j.ivanov_99@abv.bg",
                    Password = "parola123"
                },
                new User()
                {
                    FirstName = "Maria",
                    LastName = "Simeonova",
                    Email = "merry@abv.bg",
                    Password = "juuylhy13467"
                },

            };

            context.AddRange(users);

            CreditCard[] creditCards = new[]
            {
                new CreditCard()
                {
                    ExpirationDate = DateTime.Parse("2019-12-20"),
                    Limit = 400M,
                    MoneyOwned = 800M,
                },
                new CreditCard()
                {
                    ExpirationDate = DateTime.Parse("2021-02-04"),
                    Limit = 1200M,
                    MoneyOwned = 1800M,
                },
                new CreditCard()
                {
                    ExpirationDate = DateTime.Parse("2017-12-03"),
                    Limit = 400M,
                    MoneyOwned = 200M,
                },
                new CreditCard()
                {
                    ExpirationDate = DateTime.Parse("2017-10-15"),
                    Limit = 400M,
                    MoneyOwned = 0M,
                },new CreditCard()
                {
                    ExpirationDate = DateTime.Parse("2018-01-10"),
                    Limit = 900M,
                    MoneyOwned = 150M,
                },
                new CreditCard()
                {
                    ExpirationDate = DateTime.Parse("2020-09-29"),
                    Limit = 2000M,
                    MoneyOwned = 4500M,
                },
                new CreditCard()
                {
                    ExpirationDate = DateTime.Parse("2017-09-20"),
                    Limit = 400M,
                    MoneyOwned = 300M,
                }
            };

            context.AddRange(creditCards);

            BankAccount[] bankAccounts = new[]
            {
                new BankAccount()
                {
                    BankName = "DSK",
                    SWIFTCode = "BGNSF209",
                    Balance = 3000M
                },
                new BankAccount()
                {
                    BankName = "PostBank",
                    SWIFTCode = "BGNFR2041",
                    Balance = 8000M
                },
                new BankAccount()
                {
                    BankName = "Raifasen",
                    SWIFTCode = "BGNEV208",
                    Balance = 800M
                },
                new BankAccount()
                {
                    BankName = "DSK",
                    SWIFTCode = "BGNSF209",
                    Balance = 6000M
                },
                new BankAccount()
                {
                    BankName = "Raifasen",
                    SWIFTCode = "BGNEV208",
                    Balance = 12000M
                },
                new BankAccount()
                {
                    BankName = "ExpressBank",
                    SWIFTCode = "EUR2052",
                    Balance = 2000M
                },
                new BankAccount()
                {
                    BankName = "ExpressBank",
                    SWIFTCode = "EUR2052",
                    Balance = 20000M
                }
            };

            context.AddRange(bankAccounts);

            PaymentMethod[] paymentMethods = new[]
            {
                new PaymentMethod()
                {
                    Type = PaymentMethodType.CreditCard,
                    CreditCard = creditCards[0],
                    User = users[1]
                },
                new PaymentMethod()
                {
                    Type = PaymentMethodType.CreditCard,
                    CreditCard = creditCards[6],
                    User = users[4]
                },
                new PaymentMethod()
                {
                    Type = PaymentMethodType.CreditCard,
                    CreditCard = creditCards[2],
                    User = users[2]
                },
                new PaymentMethod()
                {
                    Type = PaymentMethodType.CreditCard,
                    CreditCard = creditCards[1],
                    User = users[0]
                },
                new PaymentMethod()
                {
                    Type = PaymentMethodType.BankAccount,
                    BankAccount = bankAccounts[0],
                    User = users[4]
                },
                new PaymentMethod()
                {
                    Type = PaymentMethodType.BankAccount,
                    BankAccount = bankAccounts[3],
                    User = users[3]
                },
                new PaymentMethod()
                {
                    Type = PaymentMethodType.BankAccount,
                    BankAccount = bankAccounts[4],
                    User = users[1]
                },
                new PaymentMethod()
                {
                    Type = PaymentMethodType.BankAccount,
                    BankAccount = bankAccounts[6],
                    User = users[0]
                }
            };

            PaymentMethod nullPayment = new PaymentMethod()
            {
                Type = PaymentMethodType.BankAccount,
                BankAccount = null,
                CreditCard = null,
                User = users[2]
            };

            //context.Add(nullPayment);
            context.AddRange(paymentMethods);

            context.SaveChanges();


        }

        private static void ResetDatabase(BillsPaymentSystemContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }
    }
}