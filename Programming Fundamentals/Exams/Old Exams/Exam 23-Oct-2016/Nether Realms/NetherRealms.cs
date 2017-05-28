using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var demonsBook = new List<Demon>();

            var characters = new Regex(@"[^\d\+\-\*\/\.\s\,]");
            var digits = new Regex(@"([-+\d+]+(\.\d+)?)");
            foreach (var demon in demons)
            {
                var health = 0;
                var damage = 0.0;
                var matchHealth = characters.Matches(demon);
                var matchDamage = digits.Matches(demon);
                foreach (Match number in matchDamage)
                {
                    damage += double.Parse(number.Value);
                }

                foreach (Match str in matchHealth)
                {
                    foreach (var c in str.ToString())
                    {
                        health += c;
                    }
                }

                foreach (var chararcter in demon)
                {
                    if (chararcter == '*')
                    {
                        damage *= 2;
                    }
                    else if (chararcter == '/')
                    {
                        damage /= 2;
                    }
                }

                var demonStats = new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                };

                demonsBook.Add(demonStats);
            }

            foreach (var demon in demonsBook.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }

        public class Demon
        {
            public string Name { get; set; }

            public int Health { get; set; }

            public double Damage { get; set; }
        }
    }
}
