namespace DnDCharacter
{
    public class Skill
    {
        private Skill(Ability dependingAbility, bool isClassSkill, int skillLevel, int maxSkillLevel)
        {
            DependingAbility1 = dependingAbility;
            IsClassSkill = isClassSkill;
            SkillLevel = skillLevel;
            MaxSkillLevel = maxSkillLevel;
        }

        public Ability DependingAbility1 { get; private set; }

        public int SkillLevel { get; private set; }

        public bool SetSkillLevel(int value)
        {
            if (value > MaxSkillLevel)
            {
                return false;
            }
            SkillLevel = value;
            return true;
        }

        public int MaxSkillLevel { get; set; }

        public bool IsClassSkill { get; private set; }
    }
}