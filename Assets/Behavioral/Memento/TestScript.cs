using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Memento
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var knight = new RPGCharacter("Arthur", 8000, Vector2.zero);
            var caretaker = new SnapshotManager(knight);

            caretaker.Save(knight);
            knight.PrintState();

            knight.Move(Vector3.right * 3);
            knight.PrintState();

            caretaker.Save(knight);
            knight.GetDamage(100);
            knight.PrintState();

            caretaker.Save(knight);
            knight.GetDamage(200);
            knight.PrintState();

            caretaker.Save(knight);
            knight.GetDamage(500);
            knight.PrintState();

            Debug.Log("<color=orange>Undo</color>");
            caretaker.Undo(knight);
            knight.PrintState();

            Debug.Log("<color=blue>Reset</color>");
            caretaker.Reset(knight);
            knight.PrintState();
        }
    }
}
