using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.AbstractFactory
{
    public abstract class Axe : Weapon
    {
        public Axe(int damage, GameObject view) : base(damage, view)
        {

        }

        public override void Attack()
        {
            base.Attack();
            Bleed();
        }

        protected virtual void Bleed()
        {
            Debug.Log("<color=red>Bleed</color>");
        }
    }
}
