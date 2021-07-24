using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Strategy
{
    public class LocalMapStrategy : MapStrategy
    {
        protected override void LoadMapData()
        {
            Debug.Log("Loading local map");
        }

        protected override void RenderMap()
        {
            Debug.LogWarning("Why is render logic here? Decouple your classes a bit");
            Debug.Log("Rendering map as normal");
        }
    }
}