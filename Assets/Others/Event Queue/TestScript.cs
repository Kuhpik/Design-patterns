using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Others.EventQueue
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var queue = new EventQueue();

            for (int i = 0; i < 25; i++)
            {
                queue.Listen(() => Debug.Log("First time"));
            }

            queue.Dispatch();

            for (int i = 0; i < 7; i++)
            {
                queue.Listen(() => Debug.Log("Must not be seen at first dispatch"));
            }

            queue.Dispatch();
        }
    }
}
