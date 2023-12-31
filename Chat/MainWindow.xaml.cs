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
        }

        //boton de enviar mensaje
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            // Get message written in the TextBox
            string message = MessageTextBox.Text;

            // Agregar el mensaje al ListBox (simulado como un nuevo mensaje)
            ChatListBox.Items.Add($"Tú: {message}");

            // Limpiar el TextBox después de enviar el mensaje
            MessageTextBox.Text = string.Empty;
        }
    }
}
