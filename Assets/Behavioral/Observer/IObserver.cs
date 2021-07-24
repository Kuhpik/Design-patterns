namespace Kuhpik.DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        void OnNotify(object context, object value);
    }
}