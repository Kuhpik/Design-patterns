namespace Kuhpik.DesignPatterns.Behavioral.Mediator
{
    public sealed class UIMediator : IMediator
    {
        //Imagine we're using DI
        public RestartButton RestartButton { get; set; }
        public TapToStartButton TapToStartButton { get; set; }

        void IMediator.Notify(object sender, string reason)
        {
            if (reason == "Tap")
            {
                if (sender is RestartButton)
                {
                    RestartButton.Hide();
                    TapToStartButton.Display();
                }

                else if (sender is TapToStartButton)
                {
                    RestartButton.Display();
                    TapToStartButton.Hide();
                }
            }
        }
    }
}
