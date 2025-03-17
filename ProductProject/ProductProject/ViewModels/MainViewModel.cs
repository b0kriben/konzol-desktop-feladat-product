using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentView;

        private readonly ProductCategoryViewModel _productCategoryViewModel;
        private readonly ProductViewModel _productViewModel;

        public MainViewModel()
        {
            _productCategoryViewModel = new ProductCategoryViewModel();
            _productViewModel = new ProductViewModel();
            CurrentView = _productViewModel;
        }

        [RelayCommand]
        private void ShowProductCategoryView()
        {
            CurrentView = _productCategoryViewModel;
        }

        [RelayCommand]
        private void ShowProductView()
        {
            CurrentView = _productViewModel;
        }
    }
}
