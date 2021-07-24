using System.Collections.Generic;

namespace Kuhpik.DesignPatterns.Behavioral.Observer
{
    public class PlayerStatsTracker : ISubject
    {
        readonly List<IObserver> _observers;
        readonly ISubject _subject;

        public PlayerStatsTracker()
        {
            _observers = new List<IObserver>();
            _subject = this;
        }

        public void OnLevelup(int level)
        {
            _subject.Notify("level", level);
        }

        public void OnKill(int kills)
        {
            _subject.Notify("kills", kills);
        }

        public void OnFacebookConnected()
        {
            _subject.Notify("Facebook", 0);
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        void ISubject.Notify(object context, object value)
        {
            foreach (var observer in _observers)
            {
                observer.OnNotify(context, value);
            }
        }

        public void Forget(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}