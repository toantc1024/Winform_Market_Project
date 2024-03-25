using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.IndexedProperties;
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

namespace Winform_Market_Project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        public string OrderID
        {
            get { return (string)GetValue(OrderIDProperty); }
            set { SetValue(OrderIDProperty, value); }
        }
        public static readonly DependencyProperty OrderIDProperty = DependencyProperty.Register("OrderID", typeof(string), typeof(Order));
        
        public string CustomerName
        {
            get { return (string)GetValue(CustomerNameProperty); }
            set { SetValue(CustomerNameProperty, value); }
        }
        public static readonly DependencyProperty CustomerNameProperty = DependencyProperty.Register("CustomerName", typeof(string), typeof(Order));

        public string Date
        {
            get { return (string)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }
        public static readonly DependencyProperty DateProperty = DependencyProperty.Register("Date", typeof(string), typeof(Order));

        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }
        public static readonly DependencyProperty StatusProperty = DependencyProperty.Register("Status", typeof(string), typeof(Order));

        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
        public static readonly DependencyProperty PriceProperty = DependencyProperty.Register("Price", typeof(string), typeof(Order));

    }
}
