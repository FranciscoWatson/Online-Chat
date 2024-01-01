using System.Windows.Media;

namespace Chat
{
    public class Message
    {
        private string text { get; set; }
        public Brush background { get; set; } // Utilizamos Brush para manejar colores en WPF
        public bool isSentByUser { get; set; }

        public string Text
        {
            get { return text; }
            set { this.text = value; }
        }
        public bool IsSentByUser
        {
            get { return isSentByUser; }
            set { this.isSentByUser = value; }
        }

        public string Alignment
        {
            get { return isSentByUser ? "Right" : "Left"; }
        }
        public Brush Background
        {
            get { return background; }
            set { this.background = value; }
        }


        public Message(string text, bool isSentByUser)
        {
            this.text = text;
            this.isSentByUser = isSentByUser;
            this.background = isSentByUser ? Brushes.LightBlue : Brushes.LightGreen;

        }
    }
}