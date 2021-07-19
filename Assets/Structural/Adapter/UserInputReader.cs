using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Adapter
{
    public class UserInputReader : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                //Target systems tells target's index
                //...
                UserEvents.OnAttack?.Invoke(0);
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                //Rest systems tells how much time to rest
                //...
                UserEvents.OnRest?.Invoke(5);
            }
        }
    }
}