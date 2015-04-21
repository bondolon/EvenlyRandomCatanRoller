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

        public string RobberTile;

        public bool AutomaticRobberSelection;

        private static readonly string[] _tiles = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "BB" };

        protected RollerBase(int tileCount, bool automaticRobberSelection) 
        {
            _tileCount = tileCount;

            for (int i = 0; i < _tileCount; i++)
            {
                UsableTiles.Add(_tiles[i]);
                TileHistory.Add(_tiles[i], 0);
            }

            AutomaticRobberSelection = automaticRobberSelection;
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

            var roll = GetDiceRoll();

            if (roll == 7) //Robber
            {
                TurnOutcome = ROBBER_TEXT;
                FirstTile = "HANDS";
                SecondTile = "UP";
                ThirdTile = "PARTNER!!";

                RobberTile = UsableTiles[_roller.Next(0, UsableTiles.Count)];
            }
            else
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

                while (_usedIndices.Count < resourceCount)
                {
                    SingleRoll(roll);
                }

                SetTurnOutcomeText();

                TileHistory[GetTileText(FirstTile)] += 1;

                if (!string.IsNullOrEmpty(SecondTile))
                {
                    TileHistory[GetTileText(SecondTile)] += 1;
                }

                if (!string.IsNullOrEmpty(ThirdTile))
                {
                    TileHistory[GetTileText(ThirdTile)] += 1;
                }
            }
        }

        protected void SetRollOutcomeText(string tileText, int tileNumber)
        {
            if (!string.IsNullOrEmpty(tileText))
            {
                string outcomeText = tileText;

                if (tileText == _robberLocation)
                {
                    outcomeText += "*";
                }

                if (MappedTiles != null)
                {
                    outcomeText += " - " + MappedTiles[tileText];
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
                rollText =>
                {
                    string rollOutcome = string.Empty;

                    if (!string.IsNullOrEmpty(rollText))
                    {
                        var tileText = GetTileText(rollText);

                        rollOutcome += tileText + ((tileText == _robberLocation) ? "*" : "");

                        if (MappedTiles != null)
                        {
                            rollOutcome += " (" + MappedTiles[tileText][0] + ")";
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

        protected int GetDiceRoll()
        {
            return _roller.Next(1, 7) + _roller.Next(1, 7);
        }

        public static string GetTileText(string rollOutcome)
        {
            return rollOutcome.Split(' ')[0];
        }
    }
}
