using System;

namespace DnDCharacter
{
    public class Dice
    {
        private readonly int _count;
        private readonly Random _rnd;

        public Dice(int count, int dice)
        {
            _rnd = new Random();
            _count = count;
            DiceValue = dice;
        }

        public Dice(int count, int dice, int seed)
        {
            _rnd = new Random(seed);
            _count = count;
            DiceValue = dice;
        }

        public int DiceValue { get; private set; }

        public int[] ThrowDice()
        {
            var ret = new int[ _count ];
            for ( var i = 0; i < _count; i++ )
            {
                ret[ i ] = _rnd.Next(DiceValue) + 1;
            }
            return ret;
        }

        public int ThrowAndSumDice()
        {
            var ret = 0;
            for ( var i = 0; i < _count; i++ )
            {
                ret += _rnd.Next(DiceValue) + 1;
            }
            return ret;
        }
    }
}