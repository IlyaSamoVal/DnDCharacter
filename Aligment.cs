namespace DnDCharacter
{
    public class Aligment
    {
        internal enum AligmentLawOrChaos
        {
            Lawful,
            Neutral,
            Chaotic
        }

        internal enum AligmentGoodOrEvil
        {
            Good,
            Neutral,
            Evil
        }
        private AligmentGoodOrEvil _goodOrEvil;
        private AligmentLawOrChaos _lawOrChaos;

        public Aligment(AligmentGoodOrEvil goodOrEvil, AligmentLawOrChaos lawOrChaos)
        {
            _goodOrEvil = goodOrEvil;
            _lawOrChaos = lawOrChaos;
        }

        public AligmentGoodOrEvil GoodOrEvil
        {
            get { return _goodOrEvil; }
            set { _goodOrEvil = value; }
        }

        public AligmentLawOrChaos LawOrChaos
        {
            get { return _lawOrChaos; }
            set { _lawOrChaos = value; }
        }
    }

    
}