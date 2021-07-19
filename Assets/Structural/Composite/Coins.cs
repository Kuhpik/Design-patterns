namespace Kuhpik.DesignPatterns.Structural.Composite
{
    public class Coins : ILoot
    {
        readonly int _count;

        public Coins(int count)
        {
            _count = count;
        }

        float ILoot.GetPrice()
        {
            return _count;
        }
    }
}
