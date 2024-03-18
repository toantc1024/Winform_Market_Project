using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Winform_Market_Project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ProductCard.xaml
    /// </summary>
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public Models.Product ProductData
        {
            get { return (Models.Product)GetValue(ProductDataProperty); }
            set { SetValue(ProductDataProperty, value); }
        }

        public static readonly DependencyProperty ProductDataProperty = DependencyProperty.Register("ProductData", typeof(Models.Product), typeof(ProductCard), new PropertyMetadata(default(Models.Product)));

    }
}
