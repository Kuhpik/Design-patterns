using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Observer
{
    public class ServerAchievementSystem : IObserver
    {
        void IObserver.OnNotify(object context, object value)
        {
            if (Equals(context, "Facebook"))
            {
                Debug.Log($"Server achievement observer tracked social login notification with value of {context}");
            }
        }
    }
}