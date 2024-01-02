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

namespace Chat
{
    /// <summary>
    /// Interaction logic for LogginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private EventManager eventManager;

        public LoginPage()
        {
            InitializeComponent();
        }

        public LoginPage(EventManager eventManager)
        {
            InitializeComponent();
            this.eventManager = eventManager;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Usuario")
            {
                txtUsername.Text = "";
                txtUsername.Foreground = Brushes.Black; // Change color to indicate typing
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Usuario";
                txtUsername.Foreground = Brushes.Gray; // Change color back to placeholder
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "Contraseña")
            {
                txtPassword.Password = "";
                txtPassword.Foreground = Brushes.Black; // Change color to indicate typing
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                txtPassword.Password = "Contraseña";
                txtPassword.Foreground = Brushes.Gray; // Change color back to placeholder
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            eventManager.NotifyUserContactRequested();
        }

        private void txtUsername_TextChanged_1(object sender, TextChangedEventArgs e)
        {
          
        }


    }
}
