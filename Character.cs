using System.Collections.Generic;
using System.Linq;

namespace DnDCharacter
{
    public class Character
    {
        private Race _race;
        private AdventurerClass _adventurerClass;
        private byte _level;

        public Character(string name, Race race, AdventurerClass adventurerClass, Dictionary<Abilities, Ability> abilities, int maxHp)
        {
            Name = name;
            _race = race;
            _adventurerClass = adventurerClass;
            _level = 1;
            Aligment = new Aligment(Aligment.AligmentGoodOrEvil.Neutral,Aligment.AligmentLawOrChaos.Neutral);
            Abilities = abilities;
            Stuff = new List<Item>();
            Veapons = new List<Veapon>();
            Armor = new List<Armor>();
            SaveThrows = _adventurerClass.ClassSaveThrows;
            CurrentHp = _adventurerClass.HpDice.DiceValue;
            MaxHp = maxHp;
            CurrentHp = maxHp;
            Feats = new List<Feat>();
            Skills = new Skills();
            HpDice = _adventurerClass.HpDice;
        }

        public string Name { get; set; }

        public Race Race
        {
            get { return _race; }
            set
            {
                if (value == _race) return;
                Feats.RemoveAll(feat => _race.Feats.Contains(feat));
                _race = value;
                Feats.AddRange(_race.Feats);
            }
        }

        public AdventurerClass AdventurerClass
        {
            get { return _adventurerClass; }
            set
            {
                if (_adventurerClass == value) return;
                Feats.RemoveAll(feat => _adventurerClass.ClassFeats.Contains(feat));
                _adventurerClass = value;
                Feats.AddRange(_adventurerClass.ClassFeats.Where(feat => feat.Prerequisite(this)));
            }
        }

        public byte Level
        {
            get { return _level; }
            set
            {
                _level = value;
                Skills.LevelUpSkills(_level);
            }
        }

        public Aligment Aligment { get; set; }

        public Dictionary<Abilities, Ability> Abilities { get; private set; }

        public List<Item> Stuff { get; private set; }

        public List<Veapon> Veapons { get; private set; }

        public List<Armor> Armor { get; private set; }

        public SaveThrows SaveThrows { get; private set; }

        public int CurrentHp { get; set; }

        public int MaxHp { get; set; }

        public List<Feat> Feats { get; private set; }

        public Skills Skills { get; private set; }

        public Dice HpDice { get; private set; }

        public CharDescription CDescription { get; private set; }
    }
}
