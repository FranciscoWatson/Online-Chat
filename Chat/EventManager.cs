using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


// Observer
namespace Chat
{
    public class EventManager
    {
        public event EventHandler ContactsRequested;
        public event EventHandler CloseChatRequested;
        public event EventHandler<String> ChatRequested;

        internal void NotifyUserCloseChatRequested()
        {
            CloseChatRequested?.Invoke(this, EventArgs.Empty);
        }

        internal void NotifyUserContactRequested()
        {
            ContactsRequested?.Invoke(this, EventArgs.Empty);
        }

        internal void NotifyUserContactRequested(string userToContact)
        {
            ChatRequested?.Invoke(this, userToContact);
        }
    }
}
