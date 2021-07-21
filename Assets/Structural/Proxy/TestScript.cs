using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Proxy
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var database = new TelegramDatabase();
            var proxy = new TelegramProxy(database) as IMessangerDB;

            proxy.Login("user", "password");
            proxy.PostMessage("Yes");
            proxy.GetMessagesHistory();
            proxy.PostMessage("So call me");
            proxy.PostMessage("GOD NOT THIS SONG AGAIN");
            proxy.GetMessagesHistory();
        }
    }
}
