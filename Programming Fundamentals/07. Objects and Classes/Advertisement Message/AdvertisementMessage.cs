using System;

namespace Advertisement_Message
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{GetPhrase(random)} {GetEvent(random)} {GetAuthor(random)} {GetCity(random)}");
            }
        }

        public static string GetCity(Random random)
        {
            var cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            var randomCity = random.Next(0, cities.Length);

            return cities[randomCity];
        }

        public static string GetAuthor(Random random)
        {
            var author = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            var randomAuthor = random.Next(0, author.Length);
            return author[randomAuthor];
        }

        public static string GetEvent(Random random)
        {
            var events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };
            var randomEvent = random.Next(0, events.Length);
            return events[randomEvent];
        }

        public static string GetPhrase(Random random)
        {
            var phrases = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."
            };
            var randomPhrase = random.Next(0, phrases.Length);
            return phrases[randomPhrase];
        }
    }
}
