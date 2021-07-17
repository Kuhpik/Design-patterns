using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.AbstractFactory
{
    public abstract class Weapon : IEquipment
    {
        readonly public GameObject View;
        readonly public int Damage;

        public Weapon(int damage, GameObject view = null)
        {
            Damage = damage;
        }

        public virtual void Attack()
        { 
        
        }

        public virtual void Throw()
        { 
        
        }
    }
}
