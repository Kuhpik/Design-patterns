using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Facade
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            new VideoConverterFacade().Convert();
        }
    }
}
