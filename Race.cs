using System;
using System.Collections.Generic;

namespace DnDCharacter
{
    public class Race
    {
        private readonly String _name;
        private readonly String _description;
        private readonly List<String> _prefferedNames;
        private readonly List<Feat> _feats;
        private readonly Dictionary<String, Ability> _abilityBonuses;
        private readonly AdventurerClass _prefferedAdventurerClass;
        private static readonly Dictionary<String, Race> Races=new Dictionary<string, Race>();
        private Race(string name, string description, List<string> prefferedNames, List<Feat> feats, Dictionary<string, Ability> abilityBonuses, AdventurerClass prefferedAdventurerClass)
        {
            _name = name;
            _description = description;
            _prefferedNames = prefferedNames;
            _feats = feats;
            _abilityBonuses = abilityBonuses;
            _prefferedAdventurerClass = prefferedAdventurerClass;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public List<string> PrefferedNames
        {
            get { return _prefferedNames; }
        }

        public List<Feat> Feats
        {
            get { return _feats; }
        }

        public Dictionary<string, Ability> AbilityBonuses
        {
            get { return _abilityBonuses; }
        }

        public AdventurerClass PrefferedAdventurerClass
        {
            get { return _prefferedAdventurerClass; }
        }

        public static List<Race> GetRaces()
        {
            return new List<Race>(Races.Values);
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
            Dictionary<string, Ability> abilityBonuses, AdventurerClass prefferedAdventurerClass)
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