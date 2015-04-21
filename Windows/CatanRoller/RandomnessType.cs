using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    enum RandomnessType
    {
        Unknown = 0,
        FullyRandom = 1,
        ExhaustivelyBinned = 2,
        ReverseWeighted = 3,
        ReverseMultiplicativeWeighted = 4,
        GroupedSelection = 5,
        GroupedSelectionWithShifting = 6,
        GroupedSelectionWithRefresh = 7,
        GroupedSelectionReverseWeighted = 8,
    }
}
