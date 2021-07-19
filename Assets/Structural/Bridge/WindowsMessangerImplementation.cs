namespace Kuhpik.DesignPatterns.Structural.Bridge
{
    public class WindowsMessangerImplementation : IMessangerImplementation
    {
        string IMessangerImplementation.Platform => "Windows";

        string IMessangerImplementation.ProcessChatMessage(string message)
        {
            return message;
        }

        void IMessangerImplementation.RenderBackButton()
        {
            //Rendering
            //...
        }

        void IMessangerImplementation.RenderChatView()
        {
            //Rendering
            //...
        }
    }
}
