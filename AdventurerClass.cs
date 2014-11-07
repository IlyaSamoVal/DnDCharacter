using System.Collections.Generic;

namespace DnDCharacter
{
    public class AdventurerClass
    {
        public AdventurerClass(string name, string desription, List< Feat > classFeats, Dice hpDice,
            List< Item > itemsPreset, Dictionary< int, SaveThrows > classSaveThrows, List< Skill > classSkills,
            List< List< int > > baseAttackBonusesPerLevel, int level=1)
        {
            Name = name;
            Desription = desription;
            ClassFeats = classFeats;
            HpDice = hpDice;
            ItemsPreset = itemsPreset;
            ClassSaveThrows = classSaveThrows;
            ClassSkills = classSkills;
            BaseAttackBonusesPerLevel = baseAttackBonusesPerLevel;
            Level = level;
        }

        public string Name { get; private set; }
        public string Desription { get; private set; }
        public List< Feat > ClassFeats { get; private set; }
        internal Dictionary< int, SaveThrows > ClassSaveThrows { get; private set; }
        public Dice HpDice { get; internal set; }
        public List< Item > ItemsPreset { get; internal set; }
        public List< Skill > ClassSkills { get; private set; }
        public List< List< int > > BaseAttackBonusesPerLevel { get; private set; }

        public int Level { get; private set; }
    }
}