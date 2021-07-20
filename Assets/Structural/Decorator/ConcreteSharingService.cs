using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Decorator
{
    public class ConcreteSharingService : SharingService
    {
        public override void Share()
        {
            Debug.Log("Sharing begins");
        }
    }
}