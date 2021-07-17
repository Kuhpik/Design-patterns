namespace Kuhpik.DesignPatterns.AbstractFactory
{
    public class CommonFactory : EquipmentFactory
    {
        public override Armor GetArmor()
        {
            //Some calculation or random from settings
            //...
            return new AverageArmor(10, 5);
        }

        public override Weapon GetWeapon()
        {
            //Some calculation or random from settings
            //...
            return new CommonAxe(3);
        }
    }
}
