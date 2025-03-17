using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductCategoryId { get; set; }

        public Product(int id, string name, decimal price, int productCategoryId)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Product name cannot be null or empty");

            Id = id;
            Name = name;
            Price = price;
            ProductCategoryId = productCategoryId;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
