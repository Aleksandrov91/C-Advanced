using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hornet_Comm
{
    public class HornetComm
    {
        public static void Main()
        {
            var messages = new List<Messages>();
            var broadcasts = new List<Broadcasts>();

            var messageRegex = new Regex(@"^(\d+)\s+<->\s+([\w]+)$");
            var broadcastRegex = new Regex(@"^([^0-9]+)\s+<->\s+([\w]+)$");

            var input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                var messageMatch = messageRegex.Match(input);
                if (messageMatch.Success)
                {
                    var messageFirstQuery = messageMatch.Groups[1].Value;
                    var messageSecondQuery = messageMatch.Groups[2].Value;
                    PrivateMessages(messageFirstQuery, messageSecondQuery, messages);
                }

                var broadcastMatch = broadcastRegex.Match(input);
                if (broadcastMatch.Success)
                {
                    var broadcastFirstQuery = broadcastMatch.Groups[1].Value;
                    var broadcastSecondQuery = broadcastMatch.Groups[2].Value;
                    Broadcast(broadcastFirstQuery, broadcastSecondQuery, broadcasts);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var broadcast in broadcasts)
                {
                    broadcast.SecondQuery = Letters(broadcast.SecondQuery);
                    Console.WriteLine($"{broadcast.SecondQuery} -> {broadcast.FirstQuery}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    message.FirstQuery = Reverse(message.FirstQuery);
                    Console.WriteLine($"{message.FirstQuery} -> {message.SecondQuery}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        public static void Broadcast(string firstQuery, string secondQuery, List<Broadcasts> broadcasts)
        {
            var newBroadcast = new Broadcasts
            {
                FirstQuery = firstQuery,
                SecondQuery = secondQuery
            };
            broadcasts.Add(newBroadcast);
        }

        public static void PrivateMessages(string firstQuery, string secondQuery, List<Messages> messages)
        {
            var mes = new Messages
            {
                FirstQuery = firstQuery,
                SecondQuery = secondQuery
            };
            messages.Add(mes);
        }

        public static string Reverse(string text)
        {
            char[] charArr = text.ToCharArray();
            var reverse = string.Empty;
            for (int i = charArr.Length - 1; i > -1; i--)
            {
                reverse += charArr[i];
            }

            return reverse;
        }

        public static string Letters(string text)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                var current = text[i];
                if (char.IsLower(current))
                {
                    current = char.ToUpper(current);
                }
                else if (char.IsUpper(current))
                {
                    current = char.ToLower(current);
                }

                sb.Append(current);
            }

            return sb.ToString();
        }
    }

    public class Messages
    {
        public string FirstQuery { get; set; }

        public string SecondQuery { get; set; }
    }

    public class Broadcasts
    {
        public string FirstQuery { get; set; }

        public string SecondQuery { get; set; }
    }
}
