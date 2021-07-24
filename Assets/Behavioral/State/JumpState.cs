using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.State
{
    public class JumpState : CharacterMoveState
    {
        public override void Jump()
        {
            Debug.Log("Can't jump. Wait untill grounded");
        }

        public override void Move()
        {
            Debug.Log("Moving");
        }
    }
}
