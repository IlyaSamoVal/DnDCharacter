using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDCharacter
{
    public class Race
    {
        private readonly List<String> _prefferedNames;
        private readonly List<Feat> _feats;
        private readonly Dictionary<Abilities, Ability> _abilityBonuses;
        private readonly AdventurerClass _prefferedAdventurerClass;
        private static readonly Dictionary<String, Race> Races=new Dictionary<string, Race>();
        private Race(string name, string description, List<string> prefferedNames, List<Feat> feats, Dictionary<Abilities, Ability> abilityBonuses, AdventurerClass prefferedAdventurerClass)
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

        public List<string> PrefferedNames
        {
            get { return _prefferedNames; }
        }

        public List<Feat> Feats
        {
            get { return _feats; }
        }

        public Dictionary<Abilities, Ability> AbilityBonuses
        {
            get { return _abilityBonuses; }
        }

        public AdventurerClass PrefferedAdventurerClass
        {
            get { return _prefferedAdventurerClass; }
        }

        public static List<String> GetRaces()
        {
            return new List<string>(Races.Keys);
        }

        public static Race GetRace(String raceName)
        {
            if (Races.ContainsKey(raceName))
            {
                return Races[raceName];
            }
            throw new Exception("No such race");
        }

        public static bool AddNewRace(string name, string description, List<string> prefferedNames, List<Feat> feats,
            Dictionary<Abilities, Ability> abilityBonuses, AdventurerClass prefferedAdventurerClass)
        {
            if (IsRaceExist(name))
            {
                return false;
            }
            Races.Add(name, new Race(name, description, prefferedNames, feats, abilityBonuses, prefferedAdventurerClass));
            return true;
        }

        public static bool IsRaceExist(String raceName)
        {
            return Races.ContainsKey(raceName);
        }
    }
}