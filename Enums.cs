namespace DnDCharacter
{
    public class Enums
    {
        public enum Abilities
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        }

        public enum AligmentGoodOrEvil
        {
            Good,
            Neutral,
            Evil
        }

        public enum AligmentLawOrChaos
        {
            Lawful,
            Neutral,
            Chaotic
        }

        public enum CastRequirments
        {
            Material,
            Verbal,
            Somatic,
            Focus
        }

        public enum TargetType
        {
            Object,
            Person,
            Ally,
            Enemy
        }

        public enum TypeOfFeat
        {
            General,
            ItemCreation,
            Metamagic
        }
    }
}