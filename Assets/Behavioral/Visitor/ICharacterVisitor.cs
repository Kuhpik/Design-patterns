namespace Kuhpik.DesignPatterns.Behavioral.Visitor
{
    public interface ICharacterVisitor<T>
    {
        //Price for data-hiding :D
        T Visit(Character character, int attack, int defense, int str, int agi, int dex, int luck);
    }
}