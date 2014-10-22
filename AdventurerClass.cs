using System.Collections.Generic;

namespace DnDCharacter
{
    public class AdventurerClass
    {
        private AdventurerClass(string name, string desription, List<Feat> classFeats, Dice hpDice, List<Item> itemsPreset, SaveThrows classSaveThrows, List<Skill> classSkills)
        {
            Name = name;
            Desription = desription;
            ClassFeats = classFeats;
            HpDice = hpDice;
            ItemsPreset = itemsPreset;
            ClassSaveThrows = classSaveThrows;
            ClassSkills = classSkills;
        }

        public string Name { get; private set; }

        public string Desription { get; private set; }

        public List<Feat> ClassFeats { get; private set; }

        internal SaveThrows ClassSaveThrows { get; private set; }

        public Dice HpDice { get; internal set; }

        public List<Item> ItemsPreset { get; internal set; }

        public List<Skill> ClassSkills { get; private set; }
    }
}