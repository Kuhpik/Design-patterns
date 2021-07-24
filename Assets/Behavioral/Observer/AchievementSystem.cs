using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Observer
{
    public class AchievementSystem : IObserver
    {
        void IObserver.OnNotify(object context, object value)
        {
            if (Equals(context, "level"))
            {
                Debug.Log($"Achievement observer tracked level notification with value of {value}");
            }

            else if (Equals(context, "kills"))
            {
                Debug.Log($"Achievement observer tracked kills notification with value of {value}");
            }
        }
    }
}