using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Command
{
    public class TestScript : MonoBehaviour
    {
#pragma warning disable IDE0040, CS0414
        [SerializeField] [Multiline] [ReadOnly] string _info = "Press Play button\nWatch Hierarchy window";
#pragma warning restore IDE0040, CS0414

        [Header("Settings")]
        [SerializeField] [ReadOnly] float _delayBetweenActions = 0.5f;
        [SerializeField] [ReadOnly] bool _undoEverythingInTheEnd = true;

        List<ICommand> _commands;
        WaitForSeconds _delay;

        void Start()
        {
            _commands = new List<ICommand>();
            _delay = new WaitForSeconds(_delayBetweenActions);

            var testGO = new GameObject("Test");

            _commands.Add(new ChangeHierarchyCommand(testGO, 0));
            _commands.Add(new RenameCommand(testGO, "Look here"));
            _commands.Add(new RenameCommand(testGO, "Other name"));
            _commands.Add(new ChangeHierarchyCommand(testGO, 1));
            _commands.Add(new RenameCommand(testGO, "Done"));

            StartCoroutine(TestRoutine());
        }

        IEnumerator TestRoutine()
        {
            for (int i = 0; i < _commands.Count; i++)
            {
                _commands[i].Execute();
                yield return _delay;
            }

            if (_undoEverythingInTheEnd)
            {
                yield return _delay;

                for (int i = 1; i <= _commands.Count; i++)
                {
                    _commands[_commands.Count - i].Undo();
                    yield return _delay;
                }
            }
        }
    }
}
