using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Composite
{
    public class TestScript : MonoBehaviour
    {
#pragma warning disable IDE0040, CS0414
        [SerializeField] [ReadOnly] string _info = "Please use breakpoints for testing";
#pragma warning restore IDE0040, CS0414

        [Button]
        void Test()
        {
            var loot = new LootGenerator().Generate(100, 10);
            var price = loot.GetPrice();

            Debug.Log($"Price: {price}");
        }
    }
}
