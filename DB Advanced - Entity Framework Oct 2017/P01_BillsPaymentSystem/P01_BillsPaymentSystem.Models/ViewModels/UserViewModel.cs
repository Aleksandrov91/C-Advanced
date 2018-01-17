namespace P01_BillsPaymentSystem.Data.Models.ViewModels
{
    using P01_BillsPaymentSystem.Data.Models.Enums;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class UserViewModel
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private IEnumerable<PaymentMethodViewModel> paymentMethods;

        public UserViewModel(int userId, string firstName, string lastName, string email, string password, IEnumerable<PaymentMethodViewModel> paymentMethods)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.paymentMethods = paymentMethods;
        }

        public int UserId
        {
            get
            {
                return this.userId;
            }
            private set
            {
                this.userId = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                this.email = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                this.password = value;
            }
        }

        public ICollection<PaymentMethodViewModel> PaymentMethods
        {
            get
            {
                return this.paymentMethods.ToArray();
            }
        }

        public string PayBills(decimal amount)
        {
            foreach (var pm in this.paymentMethods.OrderBy(pm => pm.Type).ThenBy(pm => pm.Id))
            {
                if (pm.PayBills(amount))
                {
                    return "Bills has been payed successfully";
                }
            }

            return "Insufficient funds!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"User: {this.FirstName} {this.LastName}");

            sb.AppendLine("Bank Accounts:");
            foreach (var bankAccount in this.paymentMethods.Where(pm => pm.Type == PaymentMethodType.BankAccount))
            {
                sb.AppendLine(bankAccount.ToString());
            }

            sb.AppendLine("Credit Cards:");
            foreach (var creditCard in this.paymentMethods.Where(pm => pm.Type == PaymentMethodType.CreditCard))
            {
                sb.AppendLine(creditCard.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
