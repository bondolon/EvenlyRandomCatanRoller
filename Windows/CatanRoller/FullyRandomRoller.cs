using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class FullyRandomRoller : RollerBase
    {
        public FullyRandomRoller(int tileCount, bool automaticRobberSelection) : 
            base(tileCount, automaticRobberSelection)
        {

        }

        protected override void SingleRoll(int roll) //ignore roll
        {
            int index = _roller.Next(0, UsableTiles.Count);

            if (!_usedIndices.Contains(index))
            {
                _usedIndices.Add(index);

                SetRollOutcomeText(UsableTiles[index], _usedIndices.Count);
            }
        }
    }
}
