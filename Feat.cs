using System;

namespace DnDCharacter
{
    public class Feat
    {
        public Feat(string name, TypeOfFeat type, Func<Character, bool> prerequisite, string benefit, string normal, string special)
        {
            Name = name;
            Type = type;
            Prerequisite = prerequisite;
            Benefit = benefit;
            Normal = normal;
            Special = special;
        }

        public string Name { get; private set; }

        public TypeOfFeat Type { get; private set; }

        public Func<Character, bool> Prerequisite { get; private set; }

        public string Benefit { get; private set; }

        public string Normal { get; private set; }

        public string Special { get; private set; }
    }

    public enum TypeOfFeat
    {
        General,
        FighterBonus,
        ItemCreation,
        Metamagic
    }
}