using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.State
{
    public class RunState : CharacterMoveState
    {
        public override void Jump()
        {
            Debug.Log("Jumping");
        }

        public override void Move()
        {
            Debug.Log("Running");
        }
    }
}
