using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Mediator
{
    public class RestartButton : UIElement
    {
        public RestartButton(IMediator mediator) : base(mediator)
        { 

        }

        public void Click()
        {
            Debug.Log("Restart button pressed");
            _mediator.Notify(this, "Tap"); //Better use enums or constants
        }

        public override void Hide()
        {
            base.Hide();
            Debug.Log("Restart button hidden");
        }
    }
}