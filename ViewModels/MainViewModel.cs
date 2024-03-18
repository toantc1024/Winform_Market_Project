using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Winform_Market_Project.Models;
using Winform_Market_Project.Views;

namespace Winform_Market_Project.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Models.Product> productItems;
        public ObservableCollection<Models.Product>  ProductItems { get => productItems; set => productItems=value; }

        public MainViewModel()
        {
            ProductItems = new ObservableCollection<Models.Product>();
            for (int i = 0; i < 100; i++)
            {
                ProductItems.Add(new Product(123, "New Balance Shoes", "I have bought for a year", "Have a scar behind the shoe", new DateTime(2020, 10, 20), 100, 75, 100, 13));
            }

        }



    }
}
