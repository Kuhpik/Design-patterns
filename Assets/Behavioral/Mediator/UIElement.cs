namespace Kuhpik.DesignPatterns.Behavioral.Mediator
{
    public abstract class UIElement
    {
        protected readonly IMediator _mediator;

        public UIElement(IMediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Display()
        { 
        
        }

        public virtual void Hide()
        { 
        
        }
    }
}