using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Winform_Market_Project.ViewModels;
using Winform_Market_Project.Views.Pages;
using Winform_Market_Project.Views.UserControls;

namespace Winform_Market_Project.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    /// 
    public partial class MainView : Window
    {
     
        public MainView()
        {
            InitializeComponent();
            RenderPage.Content = new ProductDetails();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SideBar_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
