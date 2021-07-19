namespace Kuhpik.DesignPatterns.Structural.Bridge
{
    public interface IMessangerImplementation
    {
        void RenderChatView();
        void RenderBackButton();
        string ProcessChatMessage(string message);
        string Platform { get; }
    }
}
