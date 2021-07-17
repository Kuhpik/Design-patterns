using NaughtyAttributes;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.Factory
{
    // Personaly i prefer enums over of strings.
    // Also this could be some workarround with static string value with dropdown inspector
    public class FactoryTest : MonoBehaviour
    {
        Dictionary<string, IFactory<Equipment>> _factories;

        [Button]
        void CreateWeapon()
        {
            CreateEquipment("Weapon");
        }

        [Button]
        void CreateArmor()
        {
            CreateEquipment("Armor");
        }

        void CreateEquipment(string type)
        {
            TryInitialize();
            var equipment = _factories[type].Create();
            Debug.Log($"Equipment <color=orange>{equipment.name}</color> created!");
        }

        void TryInitialize()
        {
            if (_factories == null)
            {
                _factories = GetComponentsInChildren<IFactory<Equipment>>()
                    .ToDictionary(x => x.ID, x => x);
            }
        }
    }
}
