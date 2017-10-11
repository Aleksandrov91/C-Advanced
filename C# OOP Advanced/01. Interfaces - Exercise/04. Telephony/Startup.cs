namespace _04.Telephony
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var smartphone = new Smartphone();

            var phones = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < phones.Length; i++)
            {
                smartphone.Call(phones[i]);
            }

            var webSites = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < webSites.Length; i++)
            {
                smartphone.Browse(webSites[i]);
            }

            Console.WriteLine(smartphone.ToString());
        }
    }
}
