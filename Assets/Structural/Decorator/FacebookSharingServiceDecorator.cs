using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Decorator
{
    public class FacebookSharingServiceDecorator : SharingServiceDecorator
    {
        public FacebookSharingServiceDecorator(SharingService service) : base(service)
        { 
        
        }

        public override void Share()
        {
            _service.Share();
            Debug.Log("Sharing to Facebook");
        }
    }
}