namespace Kuhpik.DesignPatterns.Behavioral.Strategy
{
    public abstract class MapStrategy : IStrategy
    {
        public virtual void Execute()
        {
            LoadMapData();
            RenderMap();
        }

        protected abstract void LoadMapData();
        protected abstract void RenderMap();
    }
}
