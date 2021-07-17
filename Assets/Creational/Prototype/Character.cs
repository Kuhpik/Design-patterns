namespace Kuhpik.DesignPatterns.Creational.Prototype
{
    public class Character : IPrototypable<Character>
    {
        readonly Inventory _inventory;
        readonly Equipment _weapon;
        readonly Equipment _armor;

        public Character(Inventory inventory, Equipment weapon, Equipment armor)
        {
            _inventory = inventory;
            _weapon = weapon;
            _armor = armor;
        }

        public Character DeepCopy()
        {
            return new Character(_inventory.DeepCopy(), _weapon.DeepCopy(), _armor.DeepCopy());
        }
    }
}
