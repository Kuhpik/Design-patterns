using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.CoR
{
    public class BuildHandler : AbstractHandler
    {
        public override void Handle()
        {
            Debug.Log("Building .aab file for current project...");
            base.Handle();
        }
    }
}
