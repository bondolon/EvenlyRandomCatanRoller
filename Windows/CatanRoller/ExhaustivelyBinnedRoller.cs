using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ExhaustivelyBinnedRoller : RollerBase
    {
        private List<string> _tileBin;

        public ExhaustivelyBinnedRoller(int tileCount, bool automaticRobberSelection)
            : base(tileCount, automaticRobberSelection)
        {
            _tileBin = new List<string>(UsableTiles);
        }

        protected override void SingleRoll(int roll) //ignore roll
        {
            if (_tileBin.Count == 0)
            {
                _tileBin = new List<string>(UsableTiles);
            }

            int index = _roller.Next(0, _tileBin.Count);

            var tileText = _tileBin[index];

            _tileBin.Remove(tileText);

            _usedIndices.Add(index);

            SetRollOutcomeText(tileText, _usedIndices.Count);
        }
    }
}
