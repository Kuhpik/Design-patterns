using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace Kuhpik.DesignPatterns.UnityRelated.EventQueue
{
    public class EventQueue
    {
        const int _delay = 1;
        const int _countPerTick = 10;

        readonly List<Action> _eventQueue;
        bool _isBusy;

        public EventQueue()
        {
            _eventQueue = new List<Action>(64);
        }

        public void Listen(Action action)
        {
            _eventQueue.Add(action);
        }

        public async void Dispatch() 
        {
            if (_isBusy) return;

            _isBusy = true;
            Debug.Log("<color=green>Dispatching new queue</color>");

            var queue = _eventQueue.ToList(); //Copy
            var countPerTick = 0;
            _eventQueue.Clear();

            for (int i = 0; i < queue.Count; i++)
            {
                queue[i].Invoke();

                countPerTick++;
                if (countPerTick == _countPerTick)
                {
                    countPerTick = 0;
                    await Task.Delay(_delay);
                    Debug.Log("<color=orange>Queue tick</color>");
                }
            }

            _isBusy = false;

            //Endless loop?
            if (_eventQueue.Count > 0)
            {
                Debug.Log("Queue is not empty. Processing...");
                Dispatch();
            }
        }
    }
}
