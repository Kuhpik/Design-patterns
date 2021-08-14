using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    // This test is very basic. 
    // How ever I do wanna see good results at first.
    // Thx to https://www.habrador.com/tutorials/programming-patterns/2-flyweight-pattern/
    public class TestScript2 : MonoBehaviour
    {
#pragma warning disable IDE0040, CS0414
        [SerializeField] int _testCount;
        [SerializeField] int _countPerFrame;
#pragma warning restore IDE0040, CS0414

        [Button]
        void SimpleInstantiate()
        {
            //Unity allocated 380 mb. Heap is 2.7 gb.
            //...

            StartCoroutine(CreationRoutine(() =>
            {
                new GameObject("Dummy").AddComponent<BigHeapSizeUnityComponent>();
            }));
        }

        [Button]
        void InstantiateWithSharedList()
        {
            //Unity allocated 380 mb. Heap is 40 mb.
            //Finally?
            //...

            var positions = new List<Vector3>();

            for (int i = 0; i < 2000; i++)
            {
                positions.Add(Vector3.one);
            }

            StartCoroutine(CreationRoutine(() =>
            {
                new GameObject("Dummy").AddComponent<FlyweightUnityComponent>().SetPositions(positions);
            }));
        }

        IEnumerator CreationRoutine(Action creationMethod)
        {
            var frames = _testCount / Mathf.Clamp(_countPerFrame, 1, int.MaxValue);

            for (int i = 0; i < frames; i++)
            {
                for (int j = 0; j < _countPerFrame; j++)
                {
                    creationMethod.Invoke();
                }

                yield return null;
            }

            yield return new WaitForSeconds(1);
            GC.Collect();
        }
    }
}