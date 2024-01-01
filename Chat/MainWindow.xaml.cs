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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public MainWindow()
        {  
            InitializeComponent();

            // Se crea Pagina de Login cuando se abre la Ventana Principal
            LoginPage logginPage = new LoginPage();
            LoginFrame.NavigationService.Navigate(logginPage);
            
            //Si el logeo es excitoso, se cargan los contactos correspondientes por defecto. 
            logginPage.ChangePageRequested += (sender, args) =>
            {
                LoginFrame.Content = null;
                ContactsPage contacts = new ContactsPage();
                ContactosFrame.NavigationService.Navigate(contacts);

                // Si el usuario elige un contacto se carga su chat con el contacto
                contacts.UserContactRequested += (sender, userToContact) =>
                {
                    //Acá es cuando se selecciona un contacto y se abre el chat.
                    MessageBox.Show($"Contacting user: {userToContact}");
                    ChatPage newChatPage = new ChatPage();
                    ChatFrame.NavigationService.Navigate(newChatPage);
                    newChatPage.ClosePageRequested += (sender, args) =>
                    {
                        ChatFrame.Content = null;
                    };
                };

            };

        }

    }
}
