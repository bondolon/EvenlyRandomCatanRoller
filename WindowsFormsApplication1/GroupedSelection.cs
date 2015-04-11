using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class GroupedSelection : RollerBase
    {
        public GroupedSelection(int tileCount, bool refreshGroupings, int refreshTurnCount)
            : base(tileCount)
        {
            FillGroupings();

            _refreshGroupings = refreshGroupings;
            _refreshTurnCount = refreshTurnCount;
        }

        private static readonly int[] _rolls = new int[] { 2, 3, 4, 5, 6, 8, 9, 10, 11, 12 };

        private Dictionary<int, Tuple<string, string, string>> _groupedTiles;

        private bool _refreshGroupings;
        private int _refreshTurnCount;

        protected override void SingleRoll(int roll) //use roll
        {
            if (_refreshGroupings && (TurnNumber % _refreshTurnCount == 0))
            {
                FillGroupings();
            }

            var tiles = _groupedTiles[roll];

            Action<string> useTile =
                tile =>
                {
                    if (!string.IsNullOrEmpty(tile))
                    {
                        _usedIndices.Add(1);

                        SetRollOutcomeText(tile, _usedIndices.Count);
                    }
                };

            useTile(tiles.Item1);
            useTile(tiles.Item2);
            useTile(tiles.Item3);
        }

        private void FillGroupings()
        {
            _groupedTiles = new Dictionary<int, Tuple<string, string, string>>();
            Queue<string> tiles = new Queue<string>();

            foreach (var tile in UsableTiles.OrderBy(x => _roller.Next()))
            {
                tiles.Enqueue(tile);
            }

            foreach (var roll in _rolls)
            {
                if (roll == 2 || roll == 12)
                {
                    if (_tileCount == 18)
                    {
                        _groupedTiles[roll] = new Tuple<string, string, string>(tiles.Dequeue(), null, null);
                    }
                    else if (_tileCount == 28)
                    {
                        _groupedTiles[roll] = new Tuple<string, string, string>(tiles.Dequeue(), tiles.Dequeue(), null);
                    }
                }
                else
                {
                    if (_tileCount == 18)
                    {
                        _groupedTiles[roll] = new Tuple<string, string, string>(tiles.Dequeue(), tiles.Dequeue(), null);
                    }
                    else if (_tileCount == 28)
                    {
                        _groupedTiles[roll] = new Tuple<string, string, string>(tiles.Dequeue(), tiles.Dequeue(), tiles.Dequeue());
                    }
                }
            }
        }    
    }
}
