namespace Kuhpik.DesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(object secnder, string reason);
    }
}
