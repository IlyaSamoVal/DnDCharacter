using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDCharacter
{
    class Skills
    {
        private Dictionary<String, Skill> skills;
        public Skill this[String SkillName]
        {
            get { return skills[SkillName]; }
        }

        public List<String> GetSkillList()
        {
            return new List<string>(skills.Keys);
        } 
        internal void LevelUpSkills(int level)
        {
            foreach (var skill in skills.Values)
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
