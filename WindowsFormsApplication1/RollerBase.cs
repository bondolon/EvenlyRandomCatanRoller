using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class RollerBase
    {
        public const string ROBBER_TEXT = "ROBBER";

        public static Dictionary<string, string> MappedTiles = null;

        public readonly List<string> UsableTiles = new List<string>();
        public readonly Dictionary<string, int> TileHistory = new Dictionary<string, int>();

        public int TurnNumber = 0;
        public string TurnOutcome;
        public string FirstTile;
        public string SecondTile;
        public string ThirdTile;

        private static readonly string[] _tiles = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "BB" };

        protected RollerBase(int tileCount) 
        {
            _tileCount = tileCount;

            for (int i = 0; i < _tileCount; i++)
            {
                UsableTiles.Add(_tiles[i]);
                TileHistory.Add(_tiles[i], 0);
            }
        }

        protected readonly int _tileCount;
        protected readonly Random _roller = new Random();

        protected List<int> _usedIndices = new List<int>();
        protected string _robberLocation;

        public void Roll(string robberLocation)
        {
            FirstTile = SecondTile = ThirdTile = string.Empty;
            _usedIndices = new List<int>();
            _robberLocation = robberLocation;

            TurnNumber++;

            int dieA = _roller.Next(1, 6);
            int dieB = _roller.Next(1, 6);

            if (dieA + dieB == 7) //Robber
            {
                TurnOutcome = ROBBER_TEXT;
                FirstTile = "HANDS";
                SecondTile = "UP";
                ThirdTile = "PARTNER!!";
            }
            else
            {
                int resourceCount = 2;

                if (dieA == dieB && (dieA == 1 || dieA == 6))
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

                while (_usedIndices.Count < resourceCount)
                {
                    SingleRoll(dieA + dieB);
                }

                SetTurnOutcomeText();

                TileHistory[FirstTile] += 1;

                if (!string.IsNullOrEmpty(SecondTile))
                {
                    TileHistory[SecondTile] += 1;
                }

                if (!string.IsNullOrEmpty(ThirdTile))
                {
                    TileHistory[ThirdTile] += 1;
                }
            }
        }

        protected void SetRollOutcomeText(string tileText, int tileNumber)
        {
            if (!string.IsNullOrEmpty(tileText))
            {
                string outcomeText;

                if (tileText == _robberLocation)
                {
                    outcomeText = "*";
                }
                else
                {
                    outcomeText = tileText;

                    if (MappedTiles != null)
                    {
                        outcomeText += " - " + MappedTiles[tileText];
                    }
                }

                if (tileNumber == 1)
                {
                    FirstTile = outcomeText;
                }
                else if (tileNumber == 2)
                {
                    SecondTile = outcomeText;
                }
                else if (tileNumber == 3)
                {
                    ThirdTile = outcomeText;
                }
            }
        }

        private void SetTurnOutcomeText()
        {
            TurnOutcome = string.Empty;

            Func<string, string> getRollOutcomeText =
                tileText =>
                {
                    string rollOutcome = string.Empty;

                    if (!string.IsNullOrEmpty(tileText))
                    {
                        rollOutcome += tileText + ((tileText == _robberLocation) ? "*" : "");

                        if (MappedTiles != null)
                        {
                            rollOutcome += ((tileText == _robberLocation) ? "*" : "") + " (" + MappedTiles[tileText][0] + ")";
                        }
                    }

                    return rollOutcome;
                };

            
            TurnOutcome += getRollOutcomeText(FirstTile) + ", ";
            TurnOutcome += getRollOutcomeText(SecondTile) + ", ";
            TurnOutcome += getRollOutcomeText(ThirdTile);

            TurnOutcome = TurnOutcome.TrimEnd(' ', ',');
        }

        protected virtual void SingleRoll(int roll)
        {
            throw new NotImplementedException("No valid randomness type was selected.");
        }
    }
}
