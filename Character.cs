using System.Collections.Generic;

namespace DnDCharacter
{
    public class Character
    {
        private string Name;
        private Race Race;
        private AdventurerClass _adventurerClass;
        private byte Level;
        private Aligment _aligment;
        private Dictionary<Abilities, Ability> Abilities;
        private List<Item> Stuff;
        private List<Veapon> Veapons;
        private List<Armor> Armor;
        private SaveThrows _saveThrows;
        private int CurrentHP;
        private int MaxHP;
        private Feats Feats;
        private Skills Skills;
        private Dice HPDice;
        private CharDescription cDescription;
    }
}
