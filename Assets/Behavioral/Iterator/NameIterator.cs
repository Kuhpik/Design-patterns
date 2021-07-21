using System.Collections.Generic;
using System.Linq;

namespace Kuhpik.DesignPatterns.Behavioral.Iterator
{
    public class NameIterator : AbstractCustomerIterator
    {
        public NameIterator(IList<CustomerData> customers) : base(customers)
        {
            Sort();
        }

        public override void Add(CustomerData customer)
        {
            base.Add(customer);
            Sort();
        }

        void Sort()
        {
            //Optimisation isnt our goal. Right?
            _customers = _customers.OrderBy(x => x.Name).ToList();
        }
    }
}