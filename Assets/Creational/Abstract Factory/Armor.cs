namespace Kuhpik.DesignPatterns.Creational.AbstractFactory
{
    public abstract class Armor : IEquipment
    {
        readonly public int Health;
        readonly public int Defense;

        public Armor(int health, int defense)
        {

        }
    }
}
