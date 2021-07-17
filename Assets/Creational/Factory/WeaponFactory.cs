using UnityEngine;

namespace Patterns.Factory
{
    public class WeaponFactory : MonoBehaviour, IFactory<Equipment>
    {
        string IFactory<Equipment>.ID => "Weapon";

        Equipment IFactory<Equipment>.Create()
        {
            var weapon = new GameObject("Weapon").AddComponent<Equipment>();
            //... do smth;
            return weapon;
        }
    }
}
