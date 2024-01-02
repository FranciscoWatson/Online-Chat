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
        private EventManager eventManager;
        private LoginPage loginPage;
        private ContactsPage contactsPage;
        private ChatPage chatPage;
        public MainWindow()
        {  
            InitializeComponent();
            this.eventManager = new EventManager();


            // Se crea Pagina de Login cuando se abre la Ventana Principal
            this.loginPage = new LoginPage(eventManager);
            LoginFrame.NavigationService.Navigate(loginPage);

            eventManager.ContactsRequested += OnContactsRequested;  //Si el logeo es excitoso, se cargan los contactos correspondientes por defecto. 


        }


        private void OnContactsRequested(object sender, EventArgs e)
        {
            LoginFrame.Content = null;
            this.contactsPage = new ContactsPage(eventManager);
            ContactosFrame.NavigationService.Navigate(contactsPage);

            eventManager.ChatRequested += OnChatRequested;

        }

        private void OnChatRequested(object sender, string userToContact)
        {
            MessageBox.Show($"Contacting user: {userToContact}");
            this.chatPage = new ChatPage(eventManager);
            ChatFrame.NavigationService.Navigate(chatPage);
            eventManager.CloseChatRequested += OnCloseChatRequested;
 
        }
        private void OnCloseChatRequested(object sender, EventArgs e)
        {
            ChatFrame.Content = null;
        }


    }
}
