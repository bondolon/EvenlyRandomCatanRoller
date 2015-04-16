using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class GroupedSelectionWithShiftingRoller : GroupedSelectionRoller
    {
        public GroupedSelectionWithShiftingRoller(int tileCount)
            : base(tileCount, false, 0)
        {
        }

        protected override void SingleRoll(int roll)
        {
            base.SingleRoll(roll);

            if (roll > 2 && roll < 12)
            {
                var rolledTiles = _groupedTiles[roll];

                var newIndex = roll > 7 ? roll + 1 : roll - 1;

                _groupedTiles[roll] = _groupedTiles[newIndex];
                _groupedTiles[newIndex] = rolledTiles;
            }
        }
    }
}
