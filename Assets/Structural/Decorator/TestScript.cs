using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Decorator
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var concrete = new ConcreteSharingService();
            var facebook = new FacebookSharingServiceDecorator(concrete);
            var gmailwithfacebook = new GMailSharingServiceDecorator(facebook);

            facebook.Share();
            gmailwithfacebook.Share();
        }
    }
}