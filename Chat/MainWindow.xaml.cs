﻿using System;
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
        List<Message> messeges = new List<Message>();
  
        public MainWindow()
        {
            InitializeComponent();
            messeges.Add(new Message("Hola", false));
            messeges.Add(new Message("Como estas?", false));
            messeges.Add(new Message("Bien", true));
            messeges.Add(new Message("Yo tambien", false));
            MessagesControl.ItemsSource = messeges;
 
        }
        
        
        //boton de enviar mensaje
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            // Get message written in the TextBox
            string message = MessageTextBox.Text;

            messeges.Add(new Message(message, true));

            // Update the ItemsSource to refresh the display
            MessagesControl.ItemsSource = null; // Clear the ItemsSource
            MessagesControl.ItemsSource = messeges; // Set the updated list as ItemsSource
            // Limpiar el TextBox después de enviar el mensaje
            MessageTextBox.Text = string.Empty;
            
        }

            
        
    }
}
