using ProductProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject.Repos
{
    public class ProductRepo
    {
        private List<Product> products;

        public ProductRepo()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public int GetNumberOfProducts()
        {
            return products.Count;
        }
    }
}
