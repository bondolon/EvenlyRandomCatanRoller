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
        public static readonly string[] Tiles = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "BB" };
        private static readonly List<string> _usableTiles = new List<string>(Tiles);
        private static readonly Dictionary<string, int> _tileHistory = new Dictionary<string,int>();

        public static Dictionary<string, string> MappedTiles = null;

        private Random _roller = new Random();

        private int _turnNumber = 0;
        private List<string> _turnHistory = new List<string>();
        private int _robberCount = 0;
        private bool _evenExhaustion = false;
        
        public Form1()
        {
            InitializeComponent();

            foreach (var tile in Tiles)
            {
                _tileHistory.Add(tile, 0);
            }

            _robberLocation.DataSource = new List<string>(new string[] { "DESERT" }.Concat(Tiles));

            _turnStatus.Text = _firstTile.Text = _secondTile.Text = _thirdTile.Text = "";
            linkLabel1.Select();
        }

        private void _rollButton_Click(object sender, EventArgs e)
        {
            if (_turnNumber == 0)
            {
                linkLabel1.Visible = linkLabel2.Visible = _assignPropertiesLink.Visible = false;
                _evenExhaustion = _enableEvenExhaustion.Checked;
                _enableEvenExhaustion.Enabled = false;
            }

            _turnStatus.Text = _firstTile.Text = _secondTile.Text = _thirdTile.Text = string.Empty;

            List<string> tiles = new List<string>();

            int dieA = _roller.Next(1, 6);
            int dieB = _roller.Next(1, 6);

            _turnNumber++;

            _playersList.ClearSelected();
            _playersList.SetSelected((_turnNumber - 1) % _playersList.Items.Count, true);

            _turnStatus.Text = string.Format("TURN {0} - {1}", _turnNumber, _playersList.SelectedItem);

            string historyText = string.Format("{0} ({1}) - ", _turnNumber, _playersList.SelectedItem);

            if (dieA + dieB == 7) //Robber
            {
                historyText += "ROBBER";
                _firstTile.Text = "HANDS";
                _secondTile.Text = "UP";
                _thirdTile.Text = "PARTNER!!";

                _robberLocation.Focus();
                _robberCount++;
            }
            else
            {
                int resourceCount = 3;

                if (dieA == dieB && (dieA == 1 || dieA == 6))
                {
                    resourceCount = 2;
                }

                List<int> usedIndices = new List<int>();

                while (usedIndices.Count < resourceCount)
                {
                    int index = _roller.Next(0, _usableTiles.Count);
                    
                    if (!usedIndices.Contains(index))
                    {
                        var tileText = _usableTiles[index];

                        if (_evenExhaustion)
                        {
                            while (_usableTiles[index] == string.Empty)
                            {
                                index = _roller.Next(0, _usableTiles.Count);
                            }

                            tileText = _usableTiles[index];    
                        }

                        usedIndices.Add(index);

                        if (MappedTiles == null)
                        {                            
                            historyText += tileText + (tileText == ((string)_robberLocation.SelectedItem) ? "*" : "") + " ";
                        }
                        else
                        {
                            historyText += tileText + (tileText == ((string)_robberLocation.SelectedItem) ? "*" : "") + " (" + MappedTiles[tileText][0] + "), ";
                        }

                        _tileHistory[tileText] = _tileHistory[tileText] + 1;

                        var testedTileText = tileText;
                        if (tileText == (string)_robberLocation.SelectedItem)
                        {
                            testedTileText = "*";
                        }

                        if (testedTileText != "*" && MappedTiles != null)
                        {
                            testedTileText += " (" + MappedTiles[tileText] + ")";
                        }

                        if (usedIndices.Count == 1)
                        {
                            _firstTile.Text = testedTileText;
                        }
                        else if (usedIndices.Count == 2)
                        {
                            _secondTile.Text = testedTileText;
                        }
                        else
                        {
                            _thirdTile.Text = testedTileText;
                        }

                        _usableTiles.RemoveAll(x => x == string.Empty);
                    }
                }

                _letterDistributionByLetter.Text = string.Empty;

                foreach (var letterKey in _tileHistory.Keys)
                {
                    _letterDistributionByLetter.Text += string.Format("{0}, {1} ({2})\r\n", letterKey, _tileHistory[letterKey], ((((double)_tileHistory[letterKey]) / _turnNumber)).ToString("P1"));
                }

                _letterDistributionByCount.Text = string.Empty;

                foreach (var letter in _tileHistory.OrderByDescending(letterPair => letterPair.Value))
                {
                    _letterDistributionByCount.Text += string.Format("{0}: {1}\r\n", letter.Key, letter.Value);
                }


                var mean = new KeyValuePair<string, int>("", 0);
                var meanNumber = _tileHistory.Values.Sum() / 2;

                var runningTotal = 0;
                foreach (var key in _tileHistory.Keys)
                {
                    runningTotal += _tileHistory[key];

                    if (runningTotal > meanNumber)
                    {
                        mean = new KeyValuePair<string, int>(key, _tileHistory[key]);
                        break;
                    }
                }

                var organizedListByCount = new List<KeyValuePair<string, int>>(_tileHistory.OrderBy(x => x.Value));
                var median = organizedListByCount[(organizedListByCount.Count / 2) + 1];
                var mode = organizedListByCount[organizedListByCount.Count - 1];

                _letterDistributionAnalysis.Text = string.Format("Mean: {0} Median: {1} Mode: {2}", mean, median, mode);
            }

            _gameStatistics.Text = string.Format("Robber Turns: {0}", _robberCount);

            _turnHistory.Add(historyText.TrimEnd(',', ' '));
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
            AssignResourcesDialog dialog = new AssignResourcesDialog();

            dialog.ShowDialog();

            if (dialog.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                MappedTiles = new Dictionary<string, string>();

                foreach (ResourceSelector selector in dialog.flowLayoutPanel1.Controls)
                {
                    MappedTiles.Add(selector.Letter.Text, (string)selector.ResourceType.SelectedItem);
                }
            }
        }
    }
}
