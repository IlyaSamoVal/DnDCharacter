namespace DnDCharacter
{
    public class Aligment
    {
        

        public Aligment(Enums.AligmentGoodOrEvil goodOrEvil, Enums.AligmentLawOrChaos lawOrChaos)
        {
            GoodOrEvil = goodOrEvil;
            LawOrChaos = lawOrChaos;
        }

        public Enums.AligmentGoodOrEvil GoodOrEvil { get; set; }
        public Enums.AligmentLawOrChaos LawOrChaos { get; set; }
    }
}