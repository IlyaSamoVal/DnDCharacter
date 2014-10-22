using System;
using System.Collections.Generic;

namespace DnDCharacter
{
    public class Skill
    {
        private Skill(string name, Ability dependingAbility, bool isClassSkill = false)
        {
            Name = name;
            DependingAbility = dependingAbility;
            IsClassSkill = isClassSkill;
            SkillLevel = 0;
        }
        private static readonly Dictionary<String, Skill> Skills = new Dictionary<string, Skill>();
        public Ability DependingAbility { get; private set; }
        public String Name { get; private set; }
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

        public static List<String> GetSkills()
        {
            return new List<string>(Skills.Keys);
        }

        public static bool IsSkillExist(String skillName)
        {
            return Skills.ContainsKey(skillName);
        }

        public static bool AddNewSkill(string name, Ability dependingAbility)
        {
            if (IsSkillExist(name)) return false;
            Skills.Add(name,new Skill(name,dependingAbility));
            return true;
        }
    }
}