using System.Collections.Generic;
using System.Linq;

namespace Kuhpik.DesignPatterns.Structural.Composite
{
    public class LootBag : ILoot
    {
        readonly IEnumerable<ILoot> _items;

        public LootBag(IEnumerable<ILoot> items)
        {
            _items = items;
        }

        float ILoot.GetPrice()
        {
            return _items.Sum(x => x.GetPrice()); //Recursion
        }
    }
}