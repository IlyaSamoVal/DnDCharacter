using System.Collections.Generic;

namespace DnDCharacter
{
    public class SpellList
    {
        public SpellList() : this(new Dictionary< int, int >(), new Dictionary< string, Spell >())
        {
        }

        public SpellList(Dictionary< int, int > availibleSpells, Dictionary< string, Spell > spells)
        {
            AvailibleSpells = availibleSpells;
            Spells = spells;
        }

        public Dictionary< int, int > AvailibleSpells { get; private set; }
        public Dictionary< string, Spell > Spells { get; private set; }
    }
}