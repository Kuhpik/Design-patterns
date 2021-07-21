using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kuhpik.DesignPatterns.Behavioral.Iterator
{
    public abstract class AbstractCustomerIterator : IEnumerable<CustomerData>
    {
        protected List<CustomerData> _customers;

        public AbstractCustomerIterator(IList<CustomerData> customers)
        {
            _customers = customers.ToList();
        }

        public virtual void Add(CustomerData customer)
        {
            _customers.Add(customer);
        }

        public virtual void Remove(CustomerData customer)
        {
            if (_customers.Contains(customer))
            {
                _customers.Remove(customer);
            }
        }

        public IEnumerator<CustomerData> GetEnumerator()
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                yield return _customers[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
