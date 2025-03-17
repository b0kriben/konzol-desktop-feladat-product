using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ProductCategory(int id, string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                throw new ArgumentException("Category name cannot be null or empty");

            Id = id;
            CategoryName = categoryName;
        }

        public override string ToString()
        {
            return $"{CategoryName}";
        }
    }
}
