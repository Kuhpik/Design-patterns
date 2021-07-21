using System;
using System.Collections.Generic;

namespace Kuhpik.DesignPatterns.Structural.Proxy
{
    public interface IMessangerDB
    {
        List<string> GetMessagesHistory();

        bool GetAuthStatus();

        void Login(string name, string password);
        void Logout();

        void PostMessage(string message);
        Action<string> OnMessageReceived { get; set; }
    }
}
