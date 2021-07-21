using System.Collections.Generic;
using System.Linq;

namespace Kuhpik.DesignPatterns.Behavioral.Iterator
{
    public class AgeIterator : AbstractCustomerIterator
    {
        public AgeIterator(IList<CustomerData> customers) : base(customers)
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
            _customers = _customers.OrderBy(x => x.Age).ToList();
        }
    }
}