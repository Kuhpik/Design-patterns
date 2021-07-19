using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Bridge
{
    public class MessangerAbstraction
    {
        readonly IMessangerImplementation _implementation;

        public MessangerAbstraction(IMessangerImplementation implementation)
        {
            _implementation = implementation;

            Initialize();
        }

        void Initialize()
        {
            _implementation.RenderChatView();
            _implementation.RenderBackButton();
        }

        public void PostMessage(string message)
        {
            var result = _implementation.ProcessChatMessage(message);
            Debug.Log($"{_implementation.Platform} output:\n{result}");
        }
    }
}
