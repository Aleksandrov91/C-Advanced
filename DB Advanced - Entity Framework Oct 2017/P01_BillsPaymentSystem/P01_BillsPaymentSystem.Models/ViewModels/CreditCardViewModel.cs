namespace P01_BillsPaymentSystem.Data.Models.ViewModels
{
    using System;
    using System.Text;

    public class CreditCardViewModel
    {
        private int creditCardId;
        private decimal limit;
        private decimal moneyOwned;
        private DateTime expirationDate;
        private decimal limitLeft;
        private decimal withdrawMoney;


        public CreditCardViewModel()
        {
            this.limitLeft = this.limit - this.withdrawMoney;
        }

        public CreditCardViewModel(int creditCardId, decimal limit, decimal moneyOwned, DateTime expirationDate)
        {
            this.creditCardId = creditCardId;
            this.limit = limit;
            this.moneyOwned = moneyOwned;
            this.expirationDate = expirationDate;
            this.limitLeft = this.limit - this.withdrawMoney;
        }

        public int CreditCardId {
            get
            {
                return this.creditCardId;
            }
            private set
            {
                this.creditCardId = value;
            }
        }

        public decimal Limit
        {
            get
            {
                return this.limit;
            }
            private set
            {
                this.limit = value;
            }
        }

        public decimal MoneyOwned
        {
            get
            {
                return this.moneyOwned;
            }
            private set
            {
                this.moneyOwned = value;
            }
        }

        public decimal LimitLeft
        {
            get
            {
                return this.limitLeft;
            }
            private set
            {
                if (value >= this.limitLeft || value >= this.Limit || value >= this.MoneyOwned)
                {
                    throw new ArgumentException();
                }

                value -= this.withdrawMoney;
            }
        }

        public DateTime ExpirationDate
        {
            get
            {
                return this.expirationDate;
            }
            private set
            {
                this.expirationDate = value;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (this.MoneyOwned >= amount && this.LimitLeft >= amount)
            {
                this.MoneyOwned -= amount;
                this.withdrawMoney += amount;
                return true;
            }

            return false;
        }

        public void Deposit(decimal amount)
        {
            this.MoneyOwned += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"-- ID: {this.CreditCardId}");
            sb.AppendLine($"--- Limit: {this.Limit}");
            sb.AppendLine($"--- Money Owned: {this.MoneyOwned}");
            sb.AppendLine($"--- Limit Left: {this.LimitLeft}");
            sb.AppendLine($"--- Expiration Date: {this.ExpirationDate.ToString("yyyy/MM")}");

            return sb.ToString();
        }
    }
}
