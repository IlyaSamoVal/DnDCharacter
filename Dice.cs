using System;

namespace DnDCharacter
{
    public class Dice
    {
        private readonly Random _rnd;
        private readonly int _count;
        private readonly int _dice;

        public Dice(int count, int dice)
        {
            _rnd = new Random();
            _count = count;
            _dice = dice;
        }

        public Dice(int count, int dice, int seed)
        {
            _rnd=new Random(seed);
            _count = count;
            _dice = dice;
        }

        public int[] ThrowDice()
        {
            var ret = new int[_count];
            for (var i = 0; i < _count; i++)
            {
                ret[i] = _rnd.Next(_dice) + 1;
            }
            return ret;
        }

        public int ThrowAndSumDice()
        {
            var ret = 0;
            for (var i = 0; i < _count; i++)
            {
                ret += _rnd.Next(_dice) + 1;
            }
            return ret;
        }

    }
}