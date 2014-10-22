using System;
using System.Collections.Generic;

namespace DnDCharacter
{
    public class Skills
    {
        private readonly Dictionary<String, Skill> _skills;

        public Skills(Dictionary<string, Skill> skills)
        {
            _skills = skills;
        }

        public Skills()
        {
            _skills = new Dictionary<string, Skill>();
        }

        public Skill this[String skillName]
        {
            get { return _skills[skillName]; }
        }

        public List<String> GetSkillList()
        {
            return new List<string>(_skills.Keys);
        } 

        internal void LevelUpSkills(int level)
        {
            foreach (var skill in _skills.Values)
            {
                if (skill.IsClassSkill)
                {
                    skill.MaxSkillLevel = level*4;
                }
                else
                {
                    skill.MaxSkillLevel = level*2;
                }
            }
        }
    }
}
