namespace P01_BillsPaymentSystem.Data.Models.ViewModels
{
    using P01_BillsPaymentSystem.Data.Models.Enums;
    using System.Text;

    public class PaymentMethodViewModel
    {
        public int Id { get; set; }

        public PaymentMethodType Type { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int? BankAccountId { get; set; }

        public BankAccountViewModel BankAccount { get; set; }

        public int? CreditCardId { get; set; }

        public CreditCardViewModel CreditCard { get; set; }

        public bool PayBills(decimal amount)
        {
            if (this.Type == PaymentMethodType.BankAccount)
            {
                return this.BankAccount.Withdraw(amount);
            }
            else if (this.Type == PaymentMethodType.CreditCard)
            {
                return this.CreditCard.Withdraw(amount);
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Type == PaymentMethodType.BankAccount)
            {
                return this.BankAccount.ToString();
            }
            else if (this.Type == PaymentMethodType.CreditCard)
            {
                return this.CreditCard.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
