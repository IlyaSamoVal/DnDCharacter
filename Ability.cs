namespace DnDCharacter
{
    public class Ability
    {
        public int Modifier
        {
            get { return (Value - 10) / 2; }
        }

        public int Value { get; set; }
    }
}