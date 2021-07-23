using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Mediator
{
    public class TapToStartButton : UIElement
    {
        public TapToStartButton(IMediator mediator) : base(mediator)
        { 
            
        }

        public void Click()
        {
            Debug.Log("Tap to start button pressed");
            _mediator.Notify(this, "Tap"); //Better use enums or constants
        }

        public override void Hide()
        {
            base.Hide();
            Debug.Log("Tap to start button hidden");
        }
    }
}