///------------------------------------------------------------------
/// uncommend for test batch mode, runs 1000 50-turn games and 
/// statstically analyzes them, with average standard deviation.
///------------------------------------------------------------------
//#define TESTROLL 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm2 : Form
    {
        private const double _weightingNumber = 1.5d;

        private static readonly Dictionary<string, int> _boardCounts = new Dictionary<string, int> { { "18+1D", 18 }, { "28+2D", 28 } };

        private static readonly Dictionary<string, RandomnessType?> _randomnessTypes = new Dictionary<string, RandomnessType?> 
        { 
            { "Catan-like", RandomnessType.GroupedSelection }, 
            { "Catan-like with shuffled groups", RandomnessType.GroupedSelectionWithRefresh },
            { "Catan-like with cutthroat groups", RandomnessType.GroupedSelectionWithShifting },
            { "Each tile selected once", RandomnessType.ExhaustivelyBinned }, 
            { "Weighted random tile selection", RandomnessType.ReverseWeighted },
            { "Random tile selection", RandomnessType.FullyRandom }, 
        };

        public RollerBase _roller;

        private List<string> _turnHistory = new List<string>();
        private int _robberCount = 0;

#if TESTROLL
        private int _sampleSize = 50;
        private int _gameCount = 1000;
#endif

        public MainForm2()
        {
            InitializeComponent();

            _tileCountSelector.Items.Clear();
            foreach (var tileCount in _boardCounts.Keys)
            {
                _tileCountSelector.Items.Add(tileCount);
            }
            _tileCountSelector.SelectedIndex = 0;

            _randomnessTypeSelector.Items.Clear();
            foreach (var randomnessType in _randomnessTypes.Keys)
            {
                _randomnessTypeSelector.Items.Add(randomnessType);
            }
            _randomnessTypeSelector.SelectedIndex = 1;

            _turnStatus.Text = _firstTile.Text = _secondTile.Text = _thirdTile.Text = "";
            _deletePlayerLink.Select();
            _playersList.Items.Clear();

#if TESTROLL
            _playersList.Items.Add("Agrippa");
            _playersList.Items.Add("Babbage");
            _playersList.Items.Add("Calvin");
            _playersList.Items.Add("Democritus");

            _baseWeightSelector.Value = 1;
            _addWeightSelector.Value = 2;
            _tileCountSelector.SelectedIndex = 1;

            _rollButton.Enabled = true;
            _randomnessTypeSelector.SelectedIndex = 0;
            _randomnessTypeSelector_SelectionChangeCommitted(null, null);            
#endif
        }

        private void _rollButton_Click(object sender, EventArgs e)
        {
            _deletePlayerLink.Enabled = _deletePlayerLink.Visible = 
                _addPlayerLink.Enabled = _addPlayerLink.Visible = 
                _assignPropertiesLink.Enabled = _assignPropertiesLink.Visible =
                _randomnessTypeSelector.Enabled = 
                _tileCountSelector.Enabled = 
                false;

            _startNewGameButton.Visible = true;

            _turnStatus.Text = _firstTile.Text = _secondTile.Text = _thirdTile.Text = string.Empty;

#if TESTROLL
            Dictionary<int, Dictionary<string, int>> gameRecords = new Dictionary<int, Dictionary<string, int>>();

            for (int game = 0; game < _gameCount; game++)
            {
#endif
            if (_roller == null)
            {
                var randomnessType = _randomnessTypes[(string)_randomnessTypeSelector.SelectedItem];

                int tileCount = _boardCounts[(string)_tileCountSelector.SelectedItem];
                switch (randomnessType)
                {
                    case RandomnessType.FullyRandom:
                        _roller = new FullyRandomRoller(tileCount);
                        break;

                    case RandomnessType.ExhaustivelyBinned:
                        _roller = new ExhaustivelyBinnedRoller(tileCount);
                        break;

                    case RandomnessType.ReverseWeighted:
                        _roller = new ReverseWeightedRoller(tileCount, 100, 1000);
                        break;

                    case RandomnessType.ReverseMultiplicativeWeighted:
                        _roller = new ReverseMultiplicativeWeightedRoller(tileCount, -1);
                        break;

                    case RandomnessType.GroupedSelection:
                        _roller = new GroupedSelectionRoller(tileCount, false, -1);
                        break;

                    case RandomnessType.GroupedSelectionWithRefresh:
                        _roller = new GroupedSelectionRoller(tileCount, true, _playersList.Items.Count);
                        break;

                    case RandomnessType.GroupedSelectionWithShifting:
                        _roller = new GroupedSelectionWithShiftingRoller(tileCount);
                        break;

                    case RandomnessType.Unknown:
                    default:
                        return;
                }

                _robberLocation.DataSource = new List<string>(new string[] { "DESERT" }.Concat(_roller.TileHistory.Keys));
                _robberSettings.Visible = true;

                SetRobberText(0);

#if !TESTROLL
                _assignPropertiesLink_LinkClicked(sender, null);
#endif
            }

#if TESTROLL
            for (int zasdfasdf = 0; zasdfasdf < _sampleSize; zasdfasdf++)
            {
#endif

            _roller.Roll((string)_robberLocation.SelectedItem);

#if !TESTROLL
            _playersList.ClearSelected();
            _playersList.SetSelected((_roller.TurnNumber - 1) % _playersList.Items.Count, true);

            _turnStatus.Text = string.Format("TURN {0} - {1}", _roller.TurnNumber, _playersList.SelectedItem);

            _firstTile.Text = _roller.FirstTile;
            _secondTile.Text = _roller.SecondTile;

            if (!string.IsNullOrEmpty(_roller.ThirdTile))
            {
                _thirdTile.Text = _roller.ThirdTile;
            }

            _letterDistributionByLetter.Text = string.Empty;

            foreach (var letterKey in _roller.TileHistory.Keys)
            {
                _letterDistributionByLetter.Text += string.Format("{0}, {1} ({2})\r\n", letterKey, _roller.TileHistory[letterKey], ((((double)_roller.TileHistory[letterKey]) / _roller.TurnNumber)).ToString("P1"));
            }

            _letterDistributionByCount.Text = string.Empty;

            foreach (var letter in _roller.TileHistory.OrderByDescending(letterPair => letterPair.Value))
            {
                _letterDistributionByCount.Text += string.Format("{0}: {1}\r\n", letter.Key, letter.Value);
            }

            var mean = new KeyValuePair<string, int>("", 0);
            var meanNumber = _roller.TileHistory.Values.Sum() / 2;

            var runningStatTotal = 0;
            foreach (var key in _roller.TileHistory.Keys)
            {
                runningStatTotal += _roller.TileHistory[key];

                if (runningStatTotal > meanNumber)
                {
                    mean = new KeyValuePair<string, int>(key, _roller.TileHistory[key]);
                    break;
                }
            }

            var organizedListByCount = new List<KeyValuePair<string, int>>(_roller.TileHistory.OrderBy(x => x.Value));
            var median = organizedListByCount[(organizedListByCount.Count / 2) + 1];
            var mode = organizedListByCount[organizedListByCount.Count - 1];

            _letterDistributionAnalysis.Text = string.Format("Mean: {0} Median: {1} Mode: {2}", mean, median, mode);

            if (_roller.TurnOutcome == RollerBase.ROBBER_TEXT)
            {
                _robberLocation.Focus();
                _robberCount++;

                SetRobberText(_robberCount);
            }

            _turnHistory.Add(string.Format("{0} ({1}) - {2}", _roller.TurnNumber, _playersList.SelectedItem, _roller.TurnOutcome));

            _turnHistoryText.Clear();

            for (int i = _turnHistory.Count - 1; i >= 0; i--)
            {
                _turnHistoryText.Text += _turnHistory[i] + "\r\n";
            }
#else
            }

            gameRecords[game] = _roller.TileHistory;

            _roller = null;
            System.Threading.Thread.Sleep(10);
    
            }

            double sum = 0.0d;

            foreach (var game in gameRecords.Keys)
            {
                var tileValues = gameRecords[game].Select(x => Convert.ToDouble(x.Value)).ToList();

                double average = tileValues.Sum() / (double)tileValues.Count;
                double sumOfSquaresOfDifferences = tileValues.Select(val => (val - average) * (val - average)).Sum();
                double standardDeviation = Math.Sqrt(sumOfSquaresOfDifferences / tileValues.Count);

                sum += standardDeviation;
                _turnHistoryText.Text += string.Format("{0}\t{1}\r\n", game + 1, standardDeviation);
            }

            _turnHistoryText.Text += sum / (double)_gameCount;
#endif
        }

        private void _addPlayerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPlayerDialog dialog = new AddPlayerDialog();
            var result = dialog.ShowDialog();

            if (dialog.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _playersList.Items.Add(dialog.PlayerName.Text);

                _rollButton.Enabled = true;
            }
        }

        private void _deletePlayerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _playersList.Items.Remove(_playersList.SelectedItem);

            if (_playersList.Items.Count == 0)
            {
                _rollButton.Enabled = false;
            }
        }

        private void _assignPropertiesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssignResourcesDialog dialog = new AssignResourcesDialog(_roller.UsableTiles);

            dialog.ShowDialog();

            if (dialog.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                RollerBase.MappedTiles = new Dictionary<string, string>();

                foreach (ResourceSelector selector in dialog.flowLayoutPanel1.Controls)
                {
                    RollerBase.MappedTiles.Add(selector.Letter.Text, (string)selector.ResourceType.SelectedItem);
                }
            }
        }

        private void _startNewGameButton_Click(object sender, EventArgs e)
        {
            _turnStatus.Text =
                _firstTile.Text =
                _secondTile.Text =
                _thirdTile.Text =
                string.Empty;

            _startNewGameButton.Visible = false;

            _playersList.ClearSelected();

            _roller = null;

            _robberSettings.Visible = false;
            _robberLocation.SelectedIndex = 0;

            _deletePlayerLink.Enabled = _deletePlayerLink.Visible =
                _addPlayerLink.Enabled = _addPlayerLink.Visible =
                _randomnessTypeSelector.Enabled =
                _tileCountSelector.Enabled =
                true;

            _turnHistory = new List<string>();

            _turnHistoryText.Text =
                _letterDistributionByLetter.Text =
                _letterDistributionByCount.Text =
                _letterDistributionAnalysis.Text = 
                string.Empty;

            SetRobberText(0);
        }

        private void SetRobberText(int robberTurns)
        {
            _robberStatistics.Text = string.Format("Robber Turns: {0}", robberTurns);
        }
    }
}
