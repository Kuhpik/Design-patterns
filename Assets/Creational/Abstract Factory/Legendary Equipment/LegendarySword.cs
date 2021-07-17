using UnityEngine;

namespace Kuhpik.DesignPatterns.AbstractFactory
{
    public class LegendarySword : Sword
    {
        public LegendarySword(int damage, GameObject view = null) : base(damage, view)
        {
            Debug.Log($"<color=yellow>Legendary</color> sword created");
        }
    }
}
