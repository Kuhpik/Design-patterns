namespace Kuhpik.DesignPatterns.Behavioral.CoR
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle();
        void OnError();
    }
}
