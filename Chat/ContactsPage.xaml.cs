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
    /// Interaction logic for Contactos.xaml
    /// </summary>
    public partial class ContactsPage : Page
    {
        private EventManager eventManager;

        public ContactsPage()
        {
            InitializeComponent();
        }

        public ContactsPage(EventManager eventManager)
        {
            InitializeComponent();
            this.eventManager = eventManager;
        }

        public event EventHandler<string>? UserContactRequested;



        private void Chatear_Click(object sender, RoutedEventArgs e)
        {
            // Logic to obtain the user to contact
            string userToContact = "John Doe"; // Replace this with your logic

            // Trigger the event by passing the user to contact
            eventManager.NotifyUserContactRequested(userToContact);

        }

            
  

    }
}

