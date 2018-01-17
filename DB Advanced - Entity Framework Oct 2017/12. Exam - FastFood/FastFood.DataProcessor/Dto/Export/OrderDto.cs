using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastFood.DataProcessor.Dto.Export
{
    public class OrderDto
    {
        public string Customer { get; set; }

        public List<OrderItemDto> Items { get; set; }

        public decimal TotalPrice => this.Items.Sum(o => (o.Price * o.Quantity));
    }
}
