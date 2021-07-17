using UnityEngine;

namespace Kuhpik.DesignPatterns.AbstractFactory
{
    public abstract class Sword : Weapon
    {
        public Sword(int damage, GameObject view) : base(damage, view)
        {

        }
    }
}
