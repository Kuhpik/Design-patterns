using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Adapter
{
    public class Warrior : MonoBehaviour
    {
        void Start()
        {
            UserEvents.OnAttack += AttackAdapter;
            UserEvents.OnRest += RestAdapter;
        }

        void AttackAdapter(int index)
        {
            //Warriors only targeting closes enemies.
            //There is no need to use enemy index

            Slash();
        }

        //Imagine there is more complex example
        void RestAdapter(float time)
        {
            Rest((decimal)time);
        }

        void Slash()
        {
            Debug.Log("Warrior's attack");
        }

        void Rest(decimal time)
        {
            Debug.Log("Warrioir's rest");
        }
    }
}
