namespace Kuhpik.DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
