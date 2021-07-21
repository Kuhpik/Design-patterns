using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.CoR
{
    public class AbstractHandler : IHandler
    {
        IHandler _handler;

        //This is real CI case
        //Reading data from disk, no special data required.
        public virtual void Handle()
        {
            Debug.Log($"Handling { GetType().Name }");
            if (_handler != null) _handler.Handle();
        }

        public virtual void OnError()
        {
            //Good practice is to create clean exception output.
            //...
            Debug.Log("Error");
        }

        public virtual IHandler SetNext(IHandler handler)
        {
            _handler = handler;
            return handler;
        }
    }
}
