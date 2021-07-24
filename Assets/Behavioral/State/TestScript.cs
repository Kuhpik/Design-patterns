using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.State
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var jumpringState = new JumpState();
            var runningState = new RunState();
            var character = new Character(runningState);

            character.SetState(null);
            character.Move();
            character.Jump();
            character.SetState(jumpringState); //State must controll it by himself but w/e

            for (int i = 0; i < 5; i++)
            {
                character.Jump();
            }

            character.SetState(runningState);
            character.Jump();
        }
    }
}
