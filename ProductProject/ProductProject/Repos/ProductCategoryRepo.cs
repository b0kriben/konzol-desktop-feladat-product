using ProductProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject.Repos
{
    public class ProductCategoryRepo
    {
        private List<ProductCategory> categories;

        public ProductCategoryRepo()
        {
            categories = new List<ProductCategory>();
        }

        public void AddCategory(ProductCategory category)
        {
            categories.Add(category);
        }

        public List<ProductCategory> GetAllCategories()
        {
            return categories;
        }

        public int GetNumberOfCategories()
        {
            return categories.Count;
        }
    }
}
