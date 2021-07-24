using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Strategy
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var navigationApp = new NavigationApp();

            navigationApp.ShowLocalTaxi();
            Debug.Log("Woah too expensive");
            navigationApp.ShowLocalWalkingRoute();
        }
    }
}
