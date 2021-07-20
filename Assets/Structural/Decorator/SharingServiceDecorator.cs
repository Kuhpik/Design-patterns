namespace Kuhpik.DesignPatterns.Structural.Decorator
{
    public abstract class SharingServiceDecorator : SharingService
    {
        protected SharingService _service;

        public SharingServiceDecorator(SharingService service)
        {
            _service = service;
        }

        public override void Share()
        {
            _service.Share();
        }
    }
}