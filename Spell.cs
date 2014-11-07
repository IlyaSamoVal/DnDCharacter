using System.Collections.Generic;

namespace DnDCharacter
{
    public class Spell
    {
        public Spell(int level, List< Item > materials, int range, Enums.TargetType targetType,
            HashSet< Enums.CastRequirments > castRequirmentses, string description, int duration, string name)
        {
            Level = level;
            Materials = materials;
            Range = range;
            TargetType = targetType;
            CastRequirmentses = castRequirmentses;
            Description = description;
            Duration = duration;
            Name = name;
        }

        public int Level { get; private set; }
        public List< Item > Materials { get; private set; }
        public int Range { get; private set; }
        public Enums.TargetType TargetType { get; private set; }
        public HashSet< Enums.CastRequirments > CastRequirmentses { get; private set; }
        public string Description { get; private set; }
        public int Duration { get; private set; }
        public string Name { get; private set; }
    }
}