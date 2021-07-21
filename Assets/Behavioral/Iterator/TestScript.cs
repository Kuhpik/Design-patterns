using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Iterator
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField] [ReadOnly] CustomerData[] _customers = new CustomerData[]
        {
            new CustomerData() { Name = "Jhon", Age = 18, OrderPrice = 29.05f },
            new CustomerData() { Name = "An", Age = 33, OrderPrice = 1.99f },
            new CustomerData() { Name = "Rick", Age = 108, OrderPrice = 20000 }
        };

        [Button]
        void TestOrderedByAge()
        {
            var iterator = new AgeIterator(_customers);

            foreach (var item in iterator)
            {
                DisplayCustomerInfo(item);
            }
        }

        [Button]
        void TestOrderedByName()
        {
            var iterator = new NameIterator(_customers);

            foreach (var item in iterator)
            {
                DisplayCustomerInfo(item);
            }
        }

        void DisplayCustomerInfo(CustomerData customer)
        {
            Debug.Log(string.Format
            (
                "{0}. {1} y.o. Order with price of {2}",
                customer.Name, customer.Age, customer.OrderPrice
            ));
        }
    }
}
