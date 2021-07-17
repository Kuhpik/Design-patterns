using UnityEngine;

namespace Kuhpik.DesignPatterns.AbstractFactory
{
    public abstract class EquipmentFactory
    {
        public abstract Weapon GetWeapon();
        public abstract Armor GetArmor();

        /// <summary>
        /// Get any supported kind of equipment
        /// </summary>
        /// <returns>Armor or Weapon with 50\50 chance</returns>
        public virtual IEquipment GetEquipment()
        {
            var rng = Random.Range(0, 100);

            if (rng < 50) return GetWeapon();
            else return GetArmor();
        }
    }
}
