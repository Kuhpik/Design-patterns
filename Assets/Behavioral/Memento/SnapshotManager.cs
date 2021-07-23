using System.Collections.Generic;
using System.Linq;

namespace Kuhpik.DesignPatterns.Behavioral.Memento
{
    public class SnapshotManager
    {
        readonly Dictionary<string, RPGCharacter> _characters; //May be unnecessary
        readonly Dictionary<string, Stack<ISnapshot>> _characterSnapshots;

        public SnapshotManager(params RPGCharacter[] characters)
        {
            _characters = characters.ToDictionary(x => x.Name, x => x);
            _characterSnapshots = characters.ToDictionary(x => x.Name, x => new Stack<ISnapshot>());
        }

        public void Save(RPGCharacter character)
        {
            Save(character.Name); //Lazy to write other methods same way :P
        }

        public void Save(string characterName)
        {
            _characterSnapshots[characterName].Push(_characters[characterName].SaveState());
        }

        public void Reset(RPGCharacter character)
        {
            var name = character.Name;
            var stack = _characterSnapshots[name];

            for (int i = 0; i < stack.Count; i++)
            {
                stack.Pop(); //Everything goes to the trash can.
            }

            var last = stack.Pop();
            last.Restore();
        }

        public void Undo(RPGCharacter character)
        {
            var name = character.Name;
            var last = _characterSnapshots[name].Pop();

            last.Restore();
        }
    }
}