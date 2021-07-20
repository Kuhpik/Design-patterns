using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Facade
{
    public class WatermarkSystem
    {
        public void TrySetWatermark()
        {
            Debug.Log("Reading license file...");
            Debug.Log("No watermark needed");
        }
    }
}
