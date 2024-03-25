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
using System.Windows.Shapes;
using Winform_Market_Project.Views.UserControls;

namespace Winform_Market_Project.Views.Pages
{
    /// <summary>
    /// Interaction logic for Tmp.xaml
    /// </summary>
    public partial class Tmp : Window
    {
        public Tmp()
        {
            InitializeComponent();
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SideBar sideBar = new SideBar();
            sideBar.Tg_Btn.IsChecked = false;
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
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
    }
}
