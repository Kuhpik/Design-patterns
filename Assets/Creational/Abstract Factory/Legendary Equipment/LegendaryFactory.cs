using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.AbstractFactory
{
    public class LegendaryFactory : EquipmentFactory
    {
        public override Armor GetArmor()
        {
            //Some calculation or random from settings
            //...
            return new AverageArmor(50, 80);
        }

        public override Weapon GetWeapon()
        {
            //Some calculation or random from settings
            //...
            return new LegendarySword(999, new GameObject("Excalibur"));
        }
    }
}
