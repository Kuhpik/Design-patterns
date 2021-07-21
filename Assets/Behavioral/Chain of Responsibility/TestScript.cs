using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.CoR
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var buildStep = new BuildHandler();
            var bundletoolStep = new BundletoolHandler();
            var apkStep = new APKHander();
            var uploadingStep = new UploadingHandler();

            buildStep.SetNext(bundletoolStep).SetNext(apkStep).SetNext(uploadingStep);
            buildStep.Handle();
        }
    }
}
