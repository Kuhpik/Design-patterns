namespace Kuhpik.DesignPatterns.Behavioral.Observer
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Forget(IObserver observer);
        void Notify(object context, object value);
    }
}