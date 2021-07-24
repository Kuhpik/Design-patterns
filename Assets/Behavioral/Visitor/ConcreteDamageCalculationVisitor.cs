namespace Kuhpik.DesignPatterns.Behavioral.Visitor
{
    public class ConcreteDamageCalculationVisitor : ICharacterVisitor<int>
    {
        int ICharacterVisitor<int>.Visit(Character character, int attack, int defense, int str, int agi, int dex, int luck)
        {
            if (character is Paladin)
            {
                return attack + str * 2;
            }

            else if (character is Mage)
            {
                return attack + luck + dex * 3;
            }

            else
            {
                return attack;
            }
        }
    }
}