using System.Text;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.Builder
{
    public class CharacterBuilder
    {
        StringBuilder _builder = new StringBuilder();

        public CharacterBuilder EquipWeapon(string weapon)
        {
            _builder.AppendLine($"Weapon: {weapon}");
            return this;
        }

        public CharacterBuilder EquipArmor(string armor)
        {
            _builder.AppendLine($"Armor: {armor}");
            return this;
        }

        public CharacterBuilder EquipPet(string pet)
        {
            _builder.AppendLine($"Pet: <color=green>{pet}</color>");
            return this;
        }

        public CharacterBuilder EquipBlessing(string blessing)
        {
            _builder.AppendLine($"Blessing: <color=orange>{blessing}</color>");
            return this;
        }

        public string Get()
        {
            _builder.Insert(0, "Character with equipment...\n");
            string result = _builder.ToString();
            Debug.Log(result);
            return result;
        }
    }
}
