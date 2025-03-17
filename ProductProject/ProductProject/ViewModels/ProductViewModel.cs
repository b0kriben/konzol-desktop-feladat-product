using CommunityToolkit.Mvvm.ComponentModel;
using ProductProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject.ViewModels
{
    public class ProductViewModel : ObservableObject
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>
        {
            new Product(1, "Laptop", 120000m, 1),
            new Product(2, "Okosóra", 25000m, 1),
            new Product(3, "Pulóver", 7000m, 2),
            new Product(4, "Tűzhely", 45000m, 3),
            new Product(5, "Társasjáték", 3000m, 4)
        };
        }
    }
}
