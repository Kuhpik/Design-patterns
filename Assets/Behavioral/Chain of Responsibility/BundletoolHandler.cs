using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.CoR
{
    public class BundletoolHandler : AbstractHandler
    {
        public override void Handle()
        {
            Debug.Log("Downloading latest bundletool from public github repo...");
            base.Handle();
        }
    }
}
