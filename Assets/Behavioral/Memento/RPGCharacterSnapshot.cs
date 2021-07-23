using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Memento
{
    public class RPGCharacterSnapshot : ISnapshot
    {
        readonly int _health;
        readonly Vector2 _position;
        readonly RPGCharacter _target;

        public RPGCharacterSnapshot(RPGCharacter character, int health, Vector2 position)
        {
            _target = character;
            _health = health;
            _position = position;
        }

        void ISnapshot.Restore()
        {
            _target.SetHealth(_health);
            _target.SetPosition(_position);
        }
    }
}