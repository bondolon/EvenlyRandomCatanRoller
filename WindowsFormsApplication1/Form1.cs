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
    public partial class Form1 : Form
    {
        private const double _weightingNumber = 1.5d;

        private static readonly Dictionary<string, int> _boardCounts = new Dictionary<string, int> { { "18+1D", 18 }, { "28+2D", 28 } };

        private static readonly Dictionary<string, RandomnessType> _randomnessTypes = new Dictionary<string, RandomnessType> 
        { 
            { "Pure", RandomnessType.Fully }, 
            { "Binned Exhaustion", RandomnessType.ExhaustivelyBinned }, 
            { "Weighted", RandomnessType.ReverseWeighted } 
        };

        public RollerBase _roller;

        private List<string> _turnHistory = new List<string>();
        private int _robberCount = 0;

        public Form1()
        {
            InitializeComponent();

            foreach (var tileCount in _boardCounts.Keys)
            {
                _tileCountSelector.Items.Add(tileCount);
            }

            _tileCountSelector.SelectedIndex = 0;

            foreach (var randomnessType in _randomnessTypes.Keys)
            {
                _randomnessTypeSelector.Items.Add(randomnessType);
            }

            _randomnessTypeSelector.SelectedIndex = 0;

            _turnStatus.Text = _firstTile.Text = _secondTile.Text = _thirdTile.Text = "";
            _deletePlayerLink.Select();
        }

        private void _rollButton_Click(object sender, EventArgs e)
        {
            _deletePlayerLink.Enabled = _deletePlayerLink.Visible = 
                _addPlayerLink.Enabled = _addPlayerLink.Visible = 
                _assignPropertiesLink.Enabled = _assignPropertiesLink.Visible =
                _randomnessTypeSelector.Enabled = 
                _tileCountSelector.Enabled = 
                false;

            _turnStatus.Text = _firstTile.Text = _secondTile.Text = _thirdTile.Text = string.Empty;

            if (_roller == null)
            {
                var randomnessType = _randomnessTypes[(string)_randomnessTypeSelector.SelectedItem];

                int tileCount = _boardCounts[(string)_tileCountSelector.SelectedItem];
                switch (randomnessType)
                {
                    case RandomnessType.Fully:
                        _roller = new FullyRandomRoller(tileCount);
                        break;

                    case RandomnessType.ExhaustivelyBinned:
                        _roller = new ExhaustivelyBinnedRoller(tileCount);
                        break;

                    case RandomnessType.ReverseWeighted:
                        _roller = new ReverseWeightedRoller(tileCount);
                        break;

                    case RandomnessType.Unknown:
                    default:
                        return;
                }

                _robberLocation.DataSource = new List<string>(new string[] { "DESERT" }.Concat(_roller.TileHistory.Keys));
                _robberLocation.Visible = _robberLocationLabel.Visible = true;

                _assignPropertiesLink_LinkClicked(sender, null);
            }

            _roller.Roll((string)_robberLocation.SelectedItem);

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

                _gameStatistics.Text = string.Format("Robber Turns: {0}", _robberCount);
            }

            _turnHistory.Add(string.Format("{0} ({1}) - {2}", _roller.TurnNumber, _playersList.SelectedItem, _roller.TurnOutcome));
            _turnHistoryText.Clear();

            for (int i = _turnHistory.Count - 1; i >= 0; i--)
            {
                _turnHistoryText.Text += _turnHistory[i] + "\r\n";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPlayerDialog dialog = new AddPlayerDialog();
            var result = dialog.ShowDialog();

            if (dialog.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _playersList.Items.Add(dialog.PlayerName.Text);

                _rollButton.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
