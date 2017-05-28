using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ClientProducts { get; set; }

        public decimal Bill { get; set; }
    }
}
