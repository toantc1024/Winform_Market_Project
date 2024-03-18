using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Winform_Market_Project.Models;
using Winform_Market_Project.ViewModels;
using Winform_Market_Project.Views.UserControls;

namespace Winform_Market_Project.Views.Pages
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : UserControl
    {

        public Products()
        {
            InitializeComponent();

        }
   

        public static readonly DependencyProperty productItems =
            DependencyProperty.Register("ProductItems", typeof(ObservableCollection<Models.Product>), typeof(Products)
                );
        public ObservableCollection<Models.Product> ProductItems
        {
            get { return (ObservableCollection<Models.Product>)GetValue(productItems); }
            set { SetValue(productItems, value); }
        }

        private void GetCurrCount(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("C: " + ProductItems.Count);

        }
    }
}
