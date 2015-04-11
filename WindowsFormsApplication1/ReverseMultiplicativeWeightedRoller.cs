using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ReverseMultiplicativeWeightedRoller : RollerBase
    {
        public ReverseMultiplicativeWeightedRoller(int tileCount, int weightFactor)
            : base(tileCount)
        {
            foreach (var tile in UsableTiles)
            {
                _weightedUsableTiles[tile] = 1;
            }

            _weightFactor = weightFactor;
        }

        private readonly Dictionary<string, decimal> _weightedUsableTiles = new Dictionary<string, decimal>();

        private int _weightFactor;

        protected override void SingleRoll(int roll) //ignore roll
        {
            const decimal minimum = 1m;

            var totalSum = _weightedUsableTiles.Values.Sum();

            byte s = 0;
            for (byte i = 0; i <= 28; i++)
            {
                if (_roller.NextDouble() >= 0.1)
                    s = i;
            }

            var a = (int)(uint.MaxValue * _roller.NextDouble());
            var b = (int)(uint.MaxValue * _roller.NextDouble());
            var c = (int)(uint.MaxValue * _roller.NextDouble());
            var n = _roller.NextDouble() >= 0.5;
            var rolledValue = (new Decimal(a, b, c, n, s) * (totalSum - minimum)) + minimum;

            int index = 0;
            decimal runningTotal = 0m;
            foreach (var tile in _weightedUsableTiles.Keys)
            {
                runningTotal += _weightedUsableTiles[tile];

                if (runningTotal >= rolledValue)
                {
                    if (_usedIndices.Contains(index))
                    {
                        break;
                    }

                    _usedIndices.Add(index);

                    SetRollOutcomeText(tile, _usedIndices.Count);

                    var tileText = tile;

                    if (_usedIndices.Count == 3)
                    {
                        for (int i = 0; i < _weightedUsableTiles.Count; i++)
                        {
                            if (!_usedIndices.Contains(i))
                            {
                                _weightedUsableTiles[UsableTiles[i]] *= _weightFactor;
                            }
                        }
                    }

                    break;
                }

                index++;
            }
        }
    }
}
