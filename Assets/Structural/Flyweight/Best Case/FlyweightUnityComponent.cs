using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class FlyweightUnityComponent : MonoBehaviour
    {
        List<Vector3> _positions;

        public void SetPositions(List<Vector3> positions)
        {
            _positions = positions;
        }
    }
}