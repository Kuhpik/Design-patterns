using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Decorator
{
    public class GMailSharingServiceDecorator : SharingServiceDecorator
    {
        public GMailSharingServiceDecorator(SharingService service) : base(service)
        { 
        
        }

        public override void Share()
        {
            _service.Share();
            Debug.Log("Sharing to GMail");
        }
    }
}