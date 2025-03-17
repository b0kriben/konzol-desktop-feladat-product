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
    public class ProductCategoryViewModel : ObservableObject
    {
        public ObservableCollection<ProductCategory> Categories { get; set; }

        public ProductCategoryViewModel()
        {
            Categories = new ObservableCollection<ProductCategory>
        {
            new ProductCategory(1, "Elektronika"),
            new ProductCategory(2, "Ruházat"),
            new ProductCategory(3, "Konyhai eszközök"),
            new ProductCategory(4, "Játékok"),
            new ProductCategory(5, "Könyvek")
        };
        }
    }
}
