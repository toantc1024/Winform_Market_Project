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
using Winform_Market_Project.Views.Pages;

namespace Winform_Market_Project.Views
{
    /// <summary>
    /// Interaction logic for AuthView.xaml
    /// </summary>
    public partial class AuthView : Window
    {
        public AuthView()
        {
            InitializeComponent();
            authPage.Content = new Login();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ChangePageToSignUp(object sender, EventArgs e)
        {
            authPage.Content = new SignUp();
        }

        public void ChangePageToSignIn(object sender, EventArgs e)
        {
            authPage.Content = new Login();
        }


        public void SignIn(string username, string password)
        {
            /// 2 template username, password
            ///     
            string ADMIN_USERNAME = "admin";
            string ADMIN_PASSWORD = "123";

            if(username==ADMIN_USERNAME && password==ADMIN_PASSWORD)
            {
                MainView view = new MainView();
                view.Show();
                this.Close();
            }   
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void Login_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AuthFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void authPage_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
