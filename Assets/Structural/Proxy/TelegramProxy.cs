using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Proxy
{
    public class TelegramProxy : IMessangerDB
    {
        IMessangerDB _database;
        List<string> _newMessages;
        List<string> _cachedMessages;
        Action<string> IMessangerDB.OnMessageReceived { get; set; }

        bool _cached;
        bool _logged;

        public TelegramProxy(TelegramDatabase database)
        {
            _database = database;
            _newMessages = new List<string>();
            _database.OnMessageReceived += ReceiveMessage;
        }

        bool IMessangerDB.GetAuthStatus()
        {
            return _logged;
        }

        //So you don't have to load full messages history everytime
        List<string> IMessangerDB.GetMessagesHistory()
        {
            if (!_cached)
            {
                _cachedMessages = _database.GetMessagesHistory().ToList();
                _newMessages.Clear(); //Important to remove copies
                _cached = true;
            }

            else
            {
                _cachedMessages.AddRange(_newMessages);
                _newMessages.Clear();
            }

            Debug.Log(string.Join("\n", _cachedMessages));

            return _cachedMessages;
        }

        void IMessangerDB.Login(string name, string password)
        {
            _database.Login(name, password);
            //if everything is OK
            //...
            _logged = true;
        }

        void IMessangerDB.Logout()
        {
            //Imagine we never lose tokens or cookies 
            _logged = false;
        }

        void IMessangerDB.PostMessage(string message)
        {
            _database.PostMessage(message);
            _newMessages.Add(message);
        }

        void ReceiveMessage(string message)
        {
            (this as IMessangerDB).OnMessageReceived?.Invoke(message);

            //Imagine we get new messages instantly
            //Like there is 1ms ping
            //I believe everyone using TS property for sorting purposes
            _newMessages.Add(message);
        }
    }
}
