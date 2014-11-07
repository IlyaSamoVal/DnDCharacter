using System;
using System.Collections.Generic;

namespace DnDCharacter
{
    public class Race
    {
        
        private readonly Dictionary< Enums.Abilities, Ability > _abilityBonuses;
        private readonly List< Feat > _feats;
        private readonly AdventurerClass _prefferedAdventurerClass;
        private readonly List< String > _prefferedNames;

        private Race(string name, string description, List< string > prefferedNames, List< Feat > feats,
            Dictionary< Enums.Abilities, Ability > abilityBonuses, AdventurerClass prefferedAdventurerClass)
        {
            Name = name;
            Description = description;
            _prefferedNames = prefferedNames;
            _feats = feats;
            _abilityBonuses = abilityBonuses;
            _prefferedAdventurerClass = prefferedAdventurerClass;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        public List< string > PrefferedNames
        {
            get { return _prefferedNames; }
        }

        public List< Feat > Feats
        {
            get { return _feats; }
        }

        public Dictionary< Enums.Abilities, Ability > AbilityBonuses
        {
            get { return _abilityBonuses; }
        }

        public AdventurerClass PrefferedAdventurerClass
        {
            get { return _prefferedAdventurerClass; }
        }

        
    }
}