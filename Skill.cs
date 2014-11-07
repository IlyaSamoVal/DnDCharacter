using System;

namespace DnDCharacter
{
    public class Skill
    {
        public Skill(string name, Ability dependingAbility, bool isClassSkill = false, bool isTrainedOnly = true)
        {
            IsTrainedOnly = isTrainedOnly;
            Name = name;
            DependingAbility = dependingAbility;
            IsClassSkill = isClassSkill;
            SkillLevel = 0;
        }

        public Ability DependingAbility { get; private set; }
        public String Name { get; private set; }
        public int SkillLevel { get; private set; }
        public int MaxSkillLevel { get; set; }
        public bool IsClassSkill { get; private set; }
        public bool IsTrainedOnly { get; private set; }

        public bool SetSkillLevel(int value)
        {
            if ( value > MaxSkillLevel )
            {
                return false;
            }
            SkillLevel = value;
            return true;
        }
    }
}