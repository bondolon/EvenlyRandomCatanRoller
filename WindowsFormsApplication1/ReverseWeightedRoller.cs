using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ReverseWeightedRoller : RollerBase
    {
        public ReverseWeightedRoller(int tileCount)
            : base(tileCount)
        {
            foreach (var tile in UsableTiles)
            {
                _weightedUsableTiles[tile] = 1;
            }
        }

        private static readonly Dictionary<string, int> _weightedUsableTiles = new Dictionary<string, int>();

        protected override void SingleRoll()
        {
            var totalSum = _weightedUsableTiles.Values.Sum();

            var rolledValue = _roller.Next(1, totalSum);

            int index = 0;
            int runningTotal = 0;
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
                                _weightedUsableTiles[UsableTiles[i]] += 1;
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
