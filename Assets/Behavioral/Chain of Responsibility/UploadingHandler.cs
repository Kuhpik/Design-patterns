using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.CoR
{
    public class UploadingHandler : AbstractHandler
    {
        public override void Handle()
        {
            Debug.Log("Sending APK to Slack chat...");
            base.Handle();
        }
    }
}
