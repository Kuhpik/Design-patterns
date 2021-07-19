using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Bridge
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var ios = new MessangerAbstraction(new IOSMessangerImplementation());
            var windows = new MessangerAbstraction(new WindowsMessangerImplementation());

            ios.PostMessage("Today is the good day. Like it af");
            windows.PostMessage("Today is the good day. Like it af");
        }
    }
}
