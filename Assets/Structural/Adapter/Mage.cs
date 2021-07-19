using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Adapter
{
    public class Mage : MonoBehaviour
    {
        void Start()
        {
            UserEvents.OnAttack += AttackAdapter;
            UserEvents.OnRest += RestAdapter;
        }

        void AttackAdapter(int index)
        {
            //Mage can attack multiple enemies at once depends of selected spell
            //Receiving AoE data
            //...
            CastSpell(new List<GameObject>());
        }

        void RestAdapter(float time)
        {
            //Mage stands still to re-generate some mana. Can be interrupted at any time.
            Rest();
        }

        void CastSpell(IEnumerable<GameObject> targets)
        {
            Debug.Log("Mage's attack");
        }

        void Rest()
        {
            Debug.Log("Mage's rest");
        }
    }
}
