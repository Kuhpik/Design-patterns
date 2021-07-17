namespace Kuhpik.DesignPatterns.Prototype
{
    public class Equipment : IPrototypable<Equipment>
    {
        Effect _effect;

        public Equipment(Effect effect)
        {
            _effect = effect;
        }

        public Equipment DeepCopy()
        {
            return new Equipment(_effect.DeepCopy());
        }
    }
}
