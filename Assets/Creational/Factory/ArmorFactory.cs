using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.Factory
{
    public class ArmorFactory : MonoBehaviour, IFactory<Equipment>
    {
        string IFactory<Equipment>.ID => "Armor";

        Equipment IFactory<Equipment>.Create()
        {
            var armor = new GameObject("Armor").AddComponent<Equipment>();
            //... do smth
            return armor;
        }
    }
}
