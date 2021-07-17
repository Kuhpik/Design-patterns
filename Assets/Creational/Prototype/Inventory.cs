using System.Collections.Generic;
using System.Linq;

namespace Kuhpik.DesignPatterns.Creational.Prototype
{
    public class Inventory : IPrototypable<Inventory>
    {
        readonly IReadOnlyList<Equipment> _items;

        public Inventory(IList<Equipment> items)
        {
            _items = items as IReadOnlyList<Equipment>;
        }

        public Inventory DeepCopy()
        {
            var items = _items.Select(x => x.DeepCopy()).ToArray(); ;
            return new Inventory(items);
        }
    }
}
