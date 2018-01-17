namespace P01_BillsPaymentSystem.Data.Models.ViewModels
{
    using System.Text;

    public class BankAccountViewModel
    {
        private int bankAccountId;
        private decimal balance;
        private string bankName;
        private string swiftCode;

        public BankAccountViewModel()
        {

        }

        public BankAccountViewModel(int bankAccountId, decimal balance, string bankName, string swiftCode)
        {
            this.bankAccountId = bankAccountId;
            this.balance = balance;
            this.bankName = bankName;
            this.swiftCode = swiftCode;
        }

        public int BankAccountId
        {
            get { return this.bankAccountId; }
            set
            {
                this.bankAccountId = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            private set
            {
                this.balance = value;
            }
        }

        public string BankName
        {
            get
            {
                return this.bankName;
            }
            private set
            {
                this.bankName = value;
            }
        }

        public string SWIFTCode
        {
            get
            {
                return this.swiftCode;
            }
            private set
            {
                this.swiftCode = value;
            }
        }
        
        public bool Withdraw(decimal amount)
        {
            if (this.Balance >= amount)
            {
                this.balance -= amount;
                return true;
            }

            return false;
        }

        public void Deposit(decimal amount)
        {
            this.balance += balance;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"-- ID: {this.BankAccountId}");
            sb.AppendLine($"--- Balance: {this.Balance:F2}");
            sb.AppendLine($"--- Bank: {this.BankName}");
            sb.AppendLine($"--- SWIFT: {this.SWIFTCode}");

            return sb.ToString().Trim();
        }
    }
}
