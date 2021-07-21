using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Command
{
    public class RenameCommand : ICommand
    {
        GameObject _object;

        string _oldName;
        string _newName;

        public RenameCommand(GameObject @object, string newName)
        {
            _object = @object;
            _newName = newName;
        }

        void ICommand.Execute()
        {
            _oldName = _object.name;
            _object.name = _newName;
        }

        void ICommand.Undo()
        {
            _object.name = _oldName;
        }
    }
}
