using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class BigHeapSizeUnityComponent : MonoBehaviour
    {
        List<Vector3> _positions;

        void Start()
        {
            _positions = new List<Vector3>();

            for (int i = 0; i < 2000; i++)
            {
                _positions.Add(Vector3.one);
            }
        }
    }
}