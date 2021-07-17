namespace Kuhpik.DesignPatterns.AbstractFactory
{
    public class RareFactory : EquipmentFactory
    {
        public override Armor GetArmor()
        {
            //Some calculation or random from settings
            //...
            return new AverageArmor(20, 50);
        }

        public override Weapon GetWeapon()
        {
            //Some calculation or random from settings
            //...
            return new RareKnife(10);
        }
    }
}
