using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Visitor
{
    public abstract class Character
    {
        //Don't want to make these fields public
        protected int _str, _dex, _agi, _luck;
        protected int _defense;
        protected int _attack;

        public Character()
        {
            _damageCulculator = new ConcreteDamageCalculationVisitor();
            Debug.Log("Character created");
        }

        protected ICharacterVisitor<int> _damageCulculator;

        public virtual void Attack()
        {
            var damage = _damageCulculator.Visit(this, _attack, _defense, _str, _agi, _dex, _luck);
            Debug.Log($"Dealed <color=orange>{damage}</color> damage");
        }
    }
}