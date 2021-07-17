using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.Prototype
{
    public class TestScript : MonoBehaviour
    {
#pragma warning disable IDE0040, CS0414
        [SerializeField] [ReadOnly] string _info = "Plase use breakpoints for testing this";
        [SerializeField] [ReadOnly] string _reason = "Im too lazy writing debug output. Seems massive";
#pragma warning restore IDE0040, CS0414

        [Button]
        void TestCharacter()
        {
            var inventoryItems = new List<Equipment>()
            {
                new Equipment(new Effect("wrath", 10, 15)),
                new Equipment(new Effect("godspeed", 10, 15, 1)),
                new Equipment(new Effect("curse", 20, 9000)),
                new Equipment(new Effect("void", 5, -1))
            };

            var inventory = new Inventory(inventoryItems);

            var weapon = new Equipment(new Effect("swordmaster", 33, -1));
            var armor = new Equipment(new Effect("protection", 100, 88, 30));

            var character = new Character(inventory, weapon, armor);
            var characterCopy = character.DeepCopy();
        }
    }
}
