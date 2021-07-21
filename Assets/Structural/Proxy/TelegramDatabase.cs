using System;
using System.Collections.Generic;

namespace Kuhpik.DesignPatterns.Structural.Proxy
{
    public class TelegramDatabase : IMessangerDB
    {
        readonly List<string> _messages;
        Action<string> IMessangerDB.OnMessageReceived { get; set; }

        public TelegramDatabase()
        {
            _messages = new List<string>();
        }

        bool IMessangerDB.GetAuthStatus()
        {
            //Check server for login status...
            //...
            return true;
        }

        List<string> IMessangerDB.GetMessagesHistory()
        {
            return _messages;
        }

        void IMessangerDB.Login(string name, string password)
        {
            //Login in
            //...
        }

        void IMessangerDB.Logout()
        {
            //Login out
            //...
        }

        void IMessangerDB.PostMessage(string message)
        {
            _messages.Add(message);
        }
    }
}
