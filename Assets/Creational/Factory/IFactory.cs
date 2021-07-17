namespace Kuhpik.DesignPatterns.Creational.Factory
{
    public interface IFactory<T> where T : class
    {
        string ID { get; }
        T Create();
    }
}
