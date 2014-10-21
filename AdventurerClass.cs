using System.Collections.Generic;

namespace DnDCharacter
{
    public class AdventurerClass
    {
        private AdventurerClass(string name, string desription, Dictionary<int, Feats> classFeats, Dice hpDice, List<Item> itemsPreset, SaveThrows claSaveDices, List<Skill> classSkills)
        {
            Name = name;
            Desription1 = desription;
            ClassFeats = classFeats;
            HpDice = hpDice;
            ItemsPreset = itemsPreset;
            ClaSaveDices = claSaveDices;
            ClassSkills = classSkills;
        }

        public string Name { get; private set; }

        public string Desription1 { get; private set; }

        public Dictionary<int, Feats> ClassFeats { get; private set; }

        internal SaveThrows ClaSaveDices { get; private set; }

        public Dice HpDice { get; internal set; }

        public List<Item> ItemsPreset { get; internal set; }

        public List<Skill> ClassSkills { get; private set; }
    }
}