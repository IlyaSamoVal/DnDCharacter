using System;

namespace DnDCharacter
{
    public class Feat
    {
        private String Name;
        private TypeOfFeat Type;
        private Func<bool, Character> Prerequisite;
        private String Benefit;
        private String Normal;
        private String Special;

    }

    internal enum TypeOfFeat
    {
        General,
        FighterBonus,
        ItemCreation,
        Metamagic
    }
}