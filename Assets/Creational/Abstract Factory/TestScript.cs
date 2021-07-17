using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.AbstractFactory
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Common()
        {
            new CommonFactory().GetEquipment();
        }

        [Button]
        void Rare()
        {
            new RareFactory().GetEquipment();
        }

        [Button]
        void Legendary()
        {
            new LegendaryFactory().GetEquipment();
        }

        [Button]
        void GetExcalibur()
        {
            new LegendaryFactory().GetWeapon();
        }
    }
}
