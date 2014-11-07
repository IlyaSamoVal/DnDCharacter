using System;

namespace DnDCharacter
{
    public class Feat
    {
        public Feat(string name, Enums.TypeOfFeat type, Func< Character, bool > prerequisite, string shortBenefit, string benefit, string normal,
            string special, bool isFigherBonusSkill)
        {
            ShortBenefit = shortBenefit;
            IsFigherBonusSkill = isFigherBonusSkill;
            Name = name;
            Type = type;
            Prerequisite = prerequisite;
            Benefit = benefit;
            Normal = normal;
            Special = special;
        }
        public bool IsFigherBonusSkill { get; private set; }
        public string Name { get; private set; }
        public Enums.TypeOfFeat Type { get; private set; }
        public Func< Character, bool > Prerequisite { get; private set; }
        public string Benefit { get; private set; }
        public string ShortBenefit { get; private set; }
        public string Normal { get; private set; }
        public string Special { get; private set; }

        public static Feat CreateFeatFromString(String str)
        {
            Console.WriteLine(str);
            var work = str.Split(';');

            return null;
        }

        public override string ToString()
        {
            return string.Format("IsFigherBonusSkill: {0}, Name: {1}, Type: {2}, Prerequisite: {3}, Benefit: {4}, " +
                                 "ShortBenefit: {5}, Normal: {6}, Special: {7}", IsFigherBonusSkill, Name, Type, 
                                 Prerequisite, Benefit, ShortBenefit, Normal, Special);
        }
    }
}