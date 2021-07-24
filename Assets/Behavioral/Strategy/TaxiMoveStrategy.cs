using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Strategy
{
    public class TaxiMoveStrategy : MoveStrategy
    {
        protected override void FindClosestWay()
        {
            Debug.Log("Building taxi way");
        }
    }
}