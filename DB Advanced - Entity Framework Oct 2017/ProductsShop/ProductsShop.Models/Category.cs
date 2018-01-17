namespace ProductsShop.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
    }
}
