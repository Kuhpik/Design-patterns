namespace Kuhpik.DesignPatterns.Behavioral.Strategy
{
    public class NavigationApp
    {
        //Using IStrategy inteface can lead to unpredictable consequences
        MapStrategy _mapStrategy;
        MoveStrategy _moveStategy;

        public void ShowLocalTaxi()
        {
            _mapStrategy = new LocalMapStrategy();
            _moveStategy = new TaxiMoveStrategy();

            DisplayInfo();
        }

        public void ShowLocalWalkingRoute()
        {
            _mapStrategy = new LocalMapStrategy();
            _moveStategy = new WalkingMoveStrategy();

            DisplayInfo();
        }

        void DisplayInfo()
        {
            _mapStrategy.Execute();
            _moveStategy.Execute();
        }
    }
}