using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class GroupedSelectionWithReverseWeightingRoller : GroupedSelectionRoller
    {
        public GroupedSelectionWithReverseWeightingRoller(int tileCount, bool automaticRobberSelection)
            : base(tileCount, automaticRobberSelection, false, 0)
        {
            var newRollOrder = new Dictionary<int, int>(_rollOrder);

            foreach (var roll in _rollOrder.Keys)
            {
                int resourceCount = 2;

                if (roll == 2 || roll == 12)
                {
                    if (_tileCount == 18)
                    {
                        resourceCount = 1;
                    }
                }
                else if (_tileCount == 28)
                {
                    resourceCount = 3;
                }

                newRollOrder[roll] = resourceCount;
            }

            _rollOrder = newRollOrder;

            foreach (var tile in UsableTiles)
            {
                _tileHistory[tile] = 0;
            }
        }

        private readonly Dictionary<int, int> _rollOrder = new Dictionary<int, int> { { 2, 0 }, { 12, 0 }, { 3, 0 }, { 11, 0 }, { 4, 0 }, { 10, 0 }, { 5, 0 }, { 9, 0 }, { 6, 0 }, { 8, 0 } };
        private Dictionary<string, int> _tileHistory = new Dictionary<string, int>();

        protected override void SingleRoll(int roll)
        {
            var tilesInOrder = _tileHistory.OrderByDescending(t => t.Value);

            var tileQueue = new Queue<string>(tilesInOrder.Select(x => x.Key));

            foreach (var rollNumber in _rollOrder.Keys)
            {
                Tuple<string, string, string> groupTiles;

                switch (_rollOrder[rollNumber])
                {
                    case 1:
                        groupTiles = new Tuple<string, string, string>(tileQueue.Dequeue(), null, null);
                        break;

                    case 2:
                        groupTiles = new Tuple<string, string, string>(tileQueue.Dequeue(), tileQueue.Dequeue(), null);
                        break;

                    case 3:
                        groupTiles = new Tuple<string, string, string>(tileQueue.Dequeue(), tileQueue.Dequeue(), tileQueue.Dequeue());
                        break;

                    default:
                        throw new Exception();
                }

                _groupedTiles[rollNumber] = groupTiles;
            }

            base.SingleRoll(roll);

            var rolledTiles = _groupedTiles[roll];

            Action<string> recordTile =
                tile =>
                {
                    if (!string.IsNullOrEmpty(tile))
                    {
                        _tileHistory[tile]++;
                    }
                };

            recordTile(rolledTiles.Item1);
            recordTile(rolledTiles.Item2);
            recordTile(rolledTiles.Item3);
        }
    }
}
