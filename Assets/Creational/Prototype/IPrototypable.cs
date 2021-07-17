namespace Kuhpik.DesignPatterns.Prototype
{
    public interface IPrototypable<T>
    {
        T DeepCopy();
    }
}
