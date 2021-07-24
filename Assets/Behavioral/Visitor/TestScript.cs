using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Visitor
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var palading = new Paladin();
            var mage = new Mage();

            palading.Attack();
            mage.Attack();
        }
    }
}
