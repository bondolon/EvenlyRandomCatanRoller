namespace WindowsFormsApplication1
{
    partial class MainForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._rollButton = new System.Windows.Forms.Button();
            this._turnStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._secondTile = new System.Windows.Forms.TextBox();
            this._thirdTile = new System.Windows.Forms.TextBox();
            this._firstTile = new System.Windows.Forms.TextBox();
            this._playersList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._tileCountSelector = new System.Windows.Forms.ListBox();
            this._randomnessTypeSelector = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this._addPlayerLink = new System.Windows.Forms.LinkLabel();
            this._deletePlayerLink = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._turnHistoryText = new System.Windows.Forms.TextBox();
            this._robberLocationLabel = new System.Windows.Forms.Label();
            this._robberLocation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._assignPropertiesLink = new System.Windows.Forms.LinkLabel();
            this._robberStatistics = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._letterDistributionByCount = new System.Windows.Forms.TextBox();
            this._letterDistributionByLetter = new System.Windows.Forms.TextBox();
            this._letterDistributionAnalysis = new System.Windows.Forms.TextBox();
            this._robberSettings = new System.Windows.Forms.Panel();
            this._startNewGameButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._automaticRobberSelectionSelector = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this._robberSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _rollButton
            // 
            this._rollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._rollButton.Enabled = false;
            this._rollButton.Location = new System.Drawing.Point(775, 15);
            this._rollButton.Name = "_rollButton";
            this._rollButton.Size = new System.Drawing.Size(75, 23);
            this._rollButton.TabIndex = 0;
            this._rollButton.Text = "Roll";
            this._rollButton.UseVisualStyleBackColor = true;
            this._rollButton.Click += new System.EventHandler(this._rollButton_Click);
            // 
            // _turnStatus
            // 
            this._turnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._turnStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._turnStatus.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._turnStatus.Location = new System.Drawing.Point(12, 43);
            this._turnStatus.Name = "_turnStatus";
            this._turnStatus.ReadOnly = true;
            this._turnStatus.Size = new System.Drawing.Size(1094, 54);
            this._turnStatus.TabIndex = 1;
            this._turnStatus.TabStop = false;
            this._turnStatus.Text = "Turn 0 - Player";
            this._turnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resource Tile Count";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this._secondTile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._thirdTile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._firstTile, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(221, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 59);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // _secondTile
            // 
            this._secondTile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._secondTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this._secondTile.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._secondTile.Location = new System.Drawing.Point(212, 3);
            this._secondTile.Name = "_secondTile";
            this._secondTile.ReadOnly = true;
            this._secondTile.Size = new System.Drawing.Size(203, 54);
            this._secondTile.TabIndex = 2;
            this._secondTile.TabStop = false;
            this._secondTile.Text = "B";
            this._secondTile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _thirdTile
            // 
            this._thirdTile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._thirdTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thirdTile.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._thirdTile.Location = new System.Drawing.Point(421, 3);
            this._thirdTile.Name = "_thirdTile";
            this._thirdTile.ReadOnly = true;
            this._thirdTile.Size = new System.Drawing.Size(205, 54);
            this._thirdTile.TabIndex = 1;
            this._thirdTile.TabStop = false;
            this._thirdTile.Text = "C";
            this._thirdTile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _firstTile
            // 
            this._firstTile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._firstTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this._firstTile.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._firstTile.Location = new System.Drawing.Point(3, 3);
            this._firstTile.Name = "_firstTile";
            this._firstTile.ReadOnly = true;
            this._firstTile.Size = new System.Drawing.Size(203, 54);
            this._firstTile.TabIndex = 0;
            this._firstTile.TabStop = false;
            this._firstTile.Text = "A";
            this._firstTile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _playersList
            // 
            this._playersList.BackColor = System.Drawing.SystemColors.Control;
            this._playersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._playersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._playersList.FormattingEnabled = true;
            this._playersList.ItemHeight = 31;
            this._playersList.Items.AddRange(new object[] {
            "Alphacles",
            "Betacles",
            "Gammacles",
            "Detalcles",
            "Epsicles",
            "Zetacles"});
            this._playersList.Location = new System.Drawing.Point(3, 16);
            this._playersList.Name = "_playersList";
            this._playersList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._playersList.Size = new System.Drawing.Size(209, 197);
            this._playersList.TabIndex = 5;
            this._playersList.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._automaticRobberSelectionSelector);
            this.groupBox1.Controls.Add(this._tileCountSelector);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._randomnessTypeSelector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // _tileCountSelector
            // 
            this._tileCountSelector.FormattingEnabled = true;
            this._tileCountSelector.Items.AddRange(new object[] {
            "18+1D",
            "28+1D"});
            this._tileCountSelector.Location = new System.Drawing.Point(6, 151);
            this._tileCountSelector.Name = "_tileCountSelector";
            this._tileCountSelector.Size = new System.Drawing.Size(202, 30);
            this._tileCountSelector.TabIndex = 14;
            // 
            // _randomnessTypeSelector
            // 
            this._randomnessTypeSelector.FormattingEnabled = true;
            this._randomnessTypeSelector.Items.AddRange(new object[] {
            "Catan-like",
            "Catan-like w/Shuffling",
            "Catan-like w/Cutthroat",
            "Reverse Weighted Catan-like",
            "Random (Binned Exhaustion)",
            "Reverse Weighted Random w/Repl.",
            "Random w/Repl."});
            this._randomnessTypeSelector.Location = new System.Drawing.Point(6, 33);
            this._randomnessTypeSelector.Name = "_randomnessTypeSelector";
            this._randomnessTypeSelector.Size = new System.Drawing.Size(202, 95);
            this._randomnessTypeSelector.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Randomness";
            // 
            // _addPlayerLink
            // 
            this._addPlayerLink.AutoSize = true;
            this._addPlayerLink.Location = new System.Drawing.Point(138, 0);
            this._addPlayerLink.Name = "_addPlayerLink";
            this._addPlayerLink.Size = new System.Drawing.Size(26, 13);
            this._addPlayerLink.TabIndex = 7;
            this._addPlayerLink.TabStop = true;
            this._addPlayerLink.Text = "Add";
            this._addPlayerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._addPlayerLink_LinkClicked);
            // 
            // _deletePlayerLink
            // 
            this._deletePlayerLink.AutoSize = true;
            this._deletePlayerLink.Location = new System.Drawing.Point(168, 0);
            this._deletePlayerLink.Name = "_deletePlayerLink";
            this._deletePlayerLink.Size = new System.Drawing.Size(38, 13);
            this._deletePlayerLink.TabIndex = 6;
            this._deletePlayerLink.TabStop = true;
            this._deletePlayerLink.Text = "Delete";
            this._deletePlayerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._deletePlayerLink_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._turnHistoryText);
            this.groupBox2.Location = new System.Drawing.Point(221, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 305);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // _turnHistoryText
            // 
            this._turnHistoryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._turnHistoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._turnHistoryText.Location = new System.Drawing.Point(3, 16);
            this._turnHistoryText.Multiline = true;
            this._turnHistoryText.Name = "_turnHistoryText";
            this._turnHistoryText.ReadOnly = true;
            this._turnHistoryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._turnHistoryText.Size = new System.Drawing.Size(623, 286);
            this._turnHistoryText.TabIndex = 0;
            this._turnHistoryText.TabStop = false;
            // 
            // _robberLocationLabel
            // 
            this._robberLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._robberLocationLabel.AutoSize = true;
            this._robberLocationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._robberLocationLabel.ForeColor = System.Drawing.Color.Firebrick;
            this._robberLocationLabel.Location = new System.Drawing.Point(-3, 3);
            this._robberLocationLabel.Name = "_robberLocationLabel";
            this._robberLocationLabel.Size = new System.Drawing.Size(119, 37);
            this._robberLocationLabel.TabIndex = 8;
            this._robberLocationLabel.Text = "Robber:";
            // 
            // _robberLocation
            // 
            this._robberLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._robberLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._robberLocation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._robberLocation.FormattingEnabled = true;
            this._robberLocation.Items.AddRange(new object[] {
            "A"});
            this._robberLocation.Location = new System.Drawing.Point(122, 6);
            this._robberLocation.Name = "_robberLocation";
            this._robberLocation.Size = new System.Drawing.Size(108, 38);
            this._robberLocation.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._assignPropertiesLink);
            this.groupBox3.Controls.Add(this._robberStatistics);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this._letterDistributionAnalysis);
            this.groupBox3.Location = new System.Drawing.Point(856, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 456);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Letter Distribution";
            // 
            // _assignPropertiesLink
            // 
            this._assignPropertiesLink.AutoSize = true;
            this._assignPropertiesLink.Location = new System.Drawing.Point(137, 0);
            this._assignPropertiesLink.Name = "_assignPropertiesLink";
            this._assignPropertiesLink.Size = new System.Drawing.Size(92, 13);
            this._assignPropertiesLink.TabIndex = 3;
            this._assignPropertiesLink.TabStop = true;
            this._assignPropertiesLink.Text = "Assign Resources";
            this._assignPropertiesLink.Visible = false;
            this._assignPropertiesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._assignPropertiesLink_LinkClicked);
            // 
            // _robberStatistics
            // 
            this._robberStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._robberStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._robberStatistics.Location = new System.Drawing.Point(7, 417);
            this._robberStatistics.Name = "_robberStatistics";
            this._robberStatistics.ReadOnly = true;
            this._robberStatistics.Size = new System.Drawing.Size(208, 13);
            this._robberStatistics.TabIndex = 2;
            this._robberStatistics.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this._letterDistributionByCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._letterDistributionByLetter, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 395);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // _letterDistributionByCount
            // 
            this._letterDistributionByCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this._letterDistributionByCount.Location = new System.Drawing.Point(115, 3);
            this._letterDistributionByCount.Multiline = true;
            this._letterDistributionByCount.Name = "_letterDistributionByCount";
            this._letterDistributionByCount.ReadOnly = true;
            this._letterDistributionByCount.Size = new System.Drawing.Size(107, 389);
            this._letterDistributionByCount.TabIndex = 1;
            this._letterDistributionByCount.TabStop = false;
            // 
            // _letterDistributionByLetter
            // 
            this._letterDistributionByLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._letterDistributionByLetter.Location = new System.Drawing.Point(3, 3);
            this._letterDistributionByLetter.Multiline = true;
            this._letterDistributionByLetter.Name = "_letterDistributionByLetter";
            this._letterDistributionByLetter.ReadOnly = true;
            this._letterDistributionByLetter.Size = new System.Drawing.Size(106, 389);
            this._letterDistributionByLetter.TabIndex = 0;
            this._letterDistributionByLetter.TabStop = false;
            // 
            // _letterDistributionAnalysis
            // 
            this._letterDistributionAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._letterDistributionAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._letterDistributionAnalysis.Location = new System.Drawing.Point(7, 436);
            this._letterDistributionAnalysis.Name = "_letterDistributionAnalysis";
            this._letterDistributionAnalysis.ReadOnly = true;
            this._letterDistributionAnalysis.Size = new System.Drawing.Size(208, 13);
            this._letterDistributionAnalysis.TabIndex = 0;
            this._letterDistributionAnalysis.TabStop = false;
            // 
            // _robberSettings
            // 
            this._robberSettings.Controls.Add(this._robberLocation);
            this._robberSettings.Controls.Add(this._robberLocationLabel);
            this._robberSettings.Location = new System.Drawing.Point(224, 2);
            this._robberSettings.Name = "_robberSettings";
            this._robberSettings.Size = new System.Drawing.Size(233, 47);
            this._robberSettings.TabIndex = 15;
            this._robberSettings.Visible = false;
            // 
            // _startNewGameButton
            // 
            this._startNewGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._startNewGameButton.Location = new System.Drawing.Point(624, 14);
            this._startNewGameButton.Name = "_startNewGameButton";
            this._startNewGameButton.Size = new System.Drawing.Size(111, 24);
            this._startNewGameButton.TabIndex = 19;
            this._startNewGameButton.Text = "Start New Game";
            this._startNewGameButton.UseVisualStyleBackColor = true;
            this._startNewGameButton.Visible = false;
            this._startNewGameButton.Click += new System.EventHandler(this._startNewGameButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this._playersList);
            this.groupBox4.Controls.Add(this._deletePlayerLink);
            this.groupBox4.Controls.Add(this._addPlayerLink);
            this.groupBox4.Location = new System.Drawing.Point(3, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 216);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Players";
            // 
            // _automaticRobberSelectionSelector
            // 
            this._automaticRobberSelectionSelector.AutoSize = true;
            this._automaticRobberSelectionSelector.Location = new System.Drawing.Point(28, 187);
            this._automaticRobberSelectionSelector.Name = "_automaticRobberSelectionSelector";
            this._automaticRobberSelectionSelector.Size = new System.Drawing.Size(158, 17);
            this._automaticRobberSelectionSelector.TabIndex = 15;
            this._automaticRobberSelectionSelector.Text = "Automatic Robber Selection";
            this._automaticRobberSelectionSelector.UseVisualStyleBackColor = true;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this._startNewGameButton);
            this.Controls.Add(this._robberSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._turnStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._rollButton);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "MainForm2";
            this.ShowIcon = false;
            this.Text = "Catan Roller";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this._robberSettings.ResumeLayout(false);
            this._robberSettings.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _rollButton;
        private System.Windows.Forms.TextBox _turnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _secondTile;
        private System.Windows.Forms.TextBox _thirdTile;
        private System.Windows.Forms.TextBox _firstTile;
        private System.Windows.Forms.ListBox _playersList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel _addPlayerLink;
        private System.Windows.Forms.LinkLabel _deletePlayerLink;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _turnHistoryText;
        private System.Windows.Forms.Label _robberLocationLabel;
        private System.Windows.Forms.ComboBox _robberLocation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _letterDistributionAnalysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox _robberStatistics;
        private System.Windows.Forms.TextBox _letterDistributionByLetter;
        private System.Windows.Forms.LinkLabel _assignPropertiesLink;
        private System.Windows.Forms.TextBox _letterDistributionByCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel _robberSettings;
        private System.Windows.Forms.Button _startNewGameButton;
        private System.Windows.Forms.ListBox _randomnessTypeSelector;
        private System.Windows.Forms.ListBox _tileCountSelector;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox _automaticRobberSelectionSelector;
    }
}

