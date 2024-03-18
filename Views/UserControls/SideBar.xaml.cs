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

namespace Winform_Market_Project.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SideBar.xaml
    /// </summary>
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //Set Tooltip Visibility
            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_store.Visibility = Visibility.Collapsed;
                tt_finance.Visibility = Visibility.Collapsed;
                tt_cart.Visibility = Visibility.Collapsed;
                tt_accountsettings.Visibility = Visibility.Collapsed;
                tt_logout.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_store.Visibility = Visibility.Visible;
                tt_finance.Visibility = Visibility.Visible;
                tt_cart.Visibility = Visibility.Visible;
                tt_accountsettings.Visibility = Visibility.Visible;
                tt_logout.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
