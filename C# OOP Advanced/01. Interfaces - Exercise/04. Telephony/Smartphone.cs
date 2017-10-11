namespace _04.Telephony
{
    using System.Linq;
    using System.Text;

    public class Smartphone : ICallable, IBrowsable
    {
        private StringBuilder callLog;
        private StringBuilder webLog;

        public Smartphone()
        {
            this.callLog = new StringBuilder();
            this.webLog = new StringBuilder();
        }

        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(p => char.IsLetter(p)))
            {
                this.callLog.AppendLine("Invalid number!");
            }
            else
            {
                this.callLog.AppendLine($"Calling... {phoneNumber}");
            }
        }

        public void Browse(string webSite)
        {
            if (webSite.Any(w => char.IsDigit(w)))
            {
                this.webLog.AppendLine("Invalid URL!");
            }
            else
            {
                this.webLog.AppendLine($"Browsing: {webSite}!");
            }
        }

        public override string ToString()
        {
            return this.callLog.ToString() + this.webLog.ToString().Trim();
        }
    }
}
