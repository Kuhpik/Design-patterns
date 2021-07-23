using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Memento
{
    public class RPGCharacter
    {
        public readonly string Name;
        //SnapshotManager class can't read private fields
        int _health;
        Vector2 _position;

        public RPGCharacter(string name, int health, Vector2 position)
        {
            Name = name;
            _health = health;
            _position = position;
        }

        public void GetDamage(int damage)
        {
            _health -= damage;
        }

        public void Move(Vector2 dir)
        {
            _position += dir;
        }

        public void SetHealth(int health)
        {
            _health = health;
        }

        public void SetPosition(Vector2 position)
        {
            _position = position;
        }

        public void PrintState()
        {
            Debug.Log($"Character {Name} is on position {_position} and has {_health}");
        }

        public ISnapshot SaveState()
        {
            return new RPGCharacterSnapshot(this, _health, _position);
        }
    }
}