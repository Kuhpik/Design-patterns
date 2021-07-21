using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Command
{
    public class ChangeHierarchyCommand : ICommand
    {
        GameObject _object;

        int _lastIndex;
        int _newIndex;

        public ChangeHierarchyCommand(GameObject @object, int newIndex)
        {
            _newIndex = newIndex;
            _object = @object;
        }

        void ICommand.Execute()
        {
            _lastIndex = _object.transform.GetSiblingIndex();
            _object.transform.SetSiblingIndex(_newIndex);
        }

        void ICommand.Undo()
        {
            _object.transform.SetSiblingIndex(_lastIndex);
        }
    }
}
