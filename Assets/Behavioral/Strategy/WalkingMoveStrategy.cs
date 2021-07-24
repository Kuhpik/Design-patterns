using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Strategy
{
    public class WalkingMoveStrategy : MoveStrategy
    {
        protected override void FindClosestWay()
        {
            Debug.Log("Buidling walking route ");
        }
    }
}