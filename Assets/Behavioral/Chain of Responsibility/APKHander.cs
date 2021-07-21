using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.CoR
{
    public class APKHander : AbstractHandler
    {
        public override void Handle()
        {
            Debug.Log("Generating APK with bundletool...");
            base.Handle();
        }

        public override void OnError()
        {
            base.OnError();
            Debug.Log("No bundletool file found. Some steps are missing");
        }
    }
}
