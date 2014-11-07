using System.Collections.Generic;
using System.Linq;

namespace DnDCharacter
{
    public class Character
    {
        private List<AdventurerClass> _adventurerClasses;
        private List< Feat > _feats;
        private byte _level;
        private Race _race;

        public Character(string name, Race race, AdventurerClass adventurerClass,
            Dictionary< Enums.Abilities, Ability > abilities)
        {
            Name = name;
            Stuff = new List< Item >();
            Veapons = new List< Veapon >();
            Armor = new List< Armor >();
            SkillList = new SkillList();
            Feats = new List< Feat >();
            SpellList = new SpellList();
            Race = race;
            AdventurerClasses = new List< AdventurerClass > {adventurerClass};
            _level = 1;
            Aligment = new Aligment(Enums.AligmentGoodOrEvil.Neutral, Enums.AligmentLawOrChaos.Neutral);
            Abilities = abilities;
            SaveThrows = adventurerClass.ClassSaveThrows[adventurerClass.Level-1];
            MaxHp = adventurerClass.HpDice.DiceValue + Abilities[Enums.Abilities.Constitution].Modifier;
            CurrentHp = MaxHp;
            HpDice = adventurerClass.HpDice;
            BaseAttack = adventurerClass.BaseAttackBonusesPerLevel[ adventurerClass.Level - 1 ];
        }

        public SpellList SpellList { get; set; }

        public string Name { get; set; }

        public Race Race
        {
            get { return _race; }
            set
            {
                if ( value == _race ) return;
                Feats.RemoveAll(feat => _race.Feats.Contains(feat));
                _race = value;
                Feats.AddRange(_race.Feats);
            }
        }

        public List< AdventurerClass > AdventurerClasses
        {
            get { return _adventurerClasses; }
            set
            {
                if ( _adventurerClasses == value ) return;
                foreach ( var @class in _adventurerClasses )
                {
                    Feats.RemoveAll(feat => @class.ClassFeats.Contains(feat));
                    
                }
                _adventurerClasses = value;
                foreach ( var @class in _adventurerClasses )
                {
                    Feats.AddRange(@class.ClassFeats.Where(feat => feat.Prerequisite(this)));
                }
            }
        }

        public byte Level
        {
            get { return _level; }
            set
            {
                _level = value;
                SkillList.LevelUpSkills(_level);
            }
        }

        public Aligment Aligment { get; set; }
        public Dictionary< Enums.Abilities, Ability > Abilities { get; private set; }
        public List< Item > Stuff { get; private set; }
        public List< Veapon > Veapons { get; private set; }
        public List< Armor > Armor { get; private set; }
        public SaveThrows SaveThrows { get; private set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }

        public List< Feat > Feats
        {
            get { return _feats; }
            private set
            {
                _feats = value;
                foreach ( var @class in AdventurerClasses )
                {
                    _feats.AddRange(@class.ClassFeats);
                }
                _feats.AddRange(Race.Feats);
            }
        }

        public SkillList SkillList { get; private set; }
        public Dice HpDice { get; private set; }
        public CharDescription CDescription { get; set; }
        public List< int > BaseAttack { get; private set; }
    }
}