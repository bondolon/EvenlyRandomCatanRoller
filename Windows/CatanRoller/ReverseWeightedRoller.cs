using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ReverseWeightedRoller : RollerBase
    {
        public ReverseWeightedRoller(int tileCount, bool automaticRobberSelection, int baseWeight, int addWeight)
            : base(tileCount, automaticRobberSelection)
        {
            foreach (var tile in UsableTiles)
            {
                _weightedUsableTiles[tile] = baseWeight;
            }

            _addWeight = addWeight;
        }

        private readonly Dictionary<string, int> _weightedUsableTiles = new Dictionary<string, int>();

        private int _addWeight;

        protected override void SingleRoll(int roll) //ignore roll
        {
            var totalSum = _weightedUsableTiles.Values.Sum();

            var rolledValue = _roller.Next(1, totalSum + 1);

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
                                _weightedUsableTiles[UsableTiles[i]] += _addWeight;
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
