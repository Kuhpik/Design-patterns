using UnityEngine;

namespace Kuhpik.DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Dummy class for test purposes
    /// </summary>
    public class AverageArmor : Armor
    {
        public AverageArmor(int health, int defense) : base(health, defense)
        {
            Debug.Log($"<color=gray>Dummy</color> armor created");
        }
    }
}
