namespace Kuhpik.DesignPatterns.Behavioral.Strategy
{
    public abstract class MoveStrategy : IStrategy
    {
        public virtual void Execute()
        {
            FindClosestWay();
        }

        protected abstract void FindClosestWay();
    }
}
