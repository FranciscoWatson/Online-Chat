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
            ChatsDisponibles chatsDisponibles = new ChatsDisponibles();
            ChatFrame.NavigationService.Navigate(chatsDisponibles);

        }
        
        
        //boton de enviar mensaje
        private void Chatear_Click(object sender, RoutedEventArgs e)
        {
            SelectedChat newChatPage = new SelectedChat(); // Crea una nueva instancia de la Page del chat
                                                           // Agrega la Page del chat al contenedor correspondiente en tu ventana principal
                                                           // (depende de cómo estés estructurando tu interfaz)
            ChatFrame.NavigationService.Navigate(newChatPage);

        }
        private void CloseChatButton_Click(object sender, RoutedEventArgs e)
        {
            ChatsDisponibles chatsDisponibles = new ChatsDisponibles();
            ChatFrame.NavigationService.Navigate(chatsDisponibles);
        }


    }
}
