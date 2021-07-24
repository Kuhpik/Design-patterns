using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.State
{
    public class Character
    {
        CharacterMoveState _moveState;

        public Character(CharacterMoveState defaultState)
        {
            _moveState = defaultState; //Avoiding null-ref exceptions
        }

        public void SetState(CharacterMoveState state)
        {
            if (state == null)
            {
                Debug.LogError("Can't operate with null state");
            }

            else
            {
                Debug.Log($"Character's state set to <color=orange>{ state.GetType().Name }</color>");
                _moveState = state;
            }
        }

        public void Move()
        {
            _moveState.Move();
        }

        public void Jump()
        {
            _moveState.Jump();
        }
    }
}
