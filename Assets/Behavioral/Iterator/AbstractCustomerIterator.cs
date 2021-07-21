using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kuhpik.DesignPatterns.Behavioral.Iterator
{
    public abstract class AbstractCustomerIterator : IEnumerable, IEnumerator
    {
        protected List<CustomerData> _customers;
        protected int _currentPosition = _defaultPosition;

        const int _defaultPosition = -1;

        public AbstractCustomerIterator(IList<CustomerData> customers)
        {
            _customers = customers.ToList();
        }

        object IEnumerator.Current => Current();
        public IEnumerator GetEnumerator() => this;

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

        public virtual object Current()
        {
            return _customers[_currentPosition];
        }

        public virtual bool MoveNext()
        {
            _currentPosition++;
            return _currentPosition < _customers.Count();
        }

        public void Reset()
        {
            _currentPosition = _defaultPosition;
        }
    }
}
