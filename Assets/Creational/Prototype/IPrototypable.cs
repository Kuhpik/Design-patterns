namespace Kuhpik.DesignPatterns.Creational.Prototype
{
    public interface IPrototypable<T>
    {
        T DeepCopy();
    }
}
