namespace DnDCharacter
{
    public class Ability
    {
        private int _value;

        public int Modifier
        {
            get { return (_value - 10)/2; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
    internal enum Abilities
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }
}