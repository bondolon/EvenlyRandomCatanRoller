namespace WindowsFormsApplication1
{
    partial class Form1
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
            this._addPlayerLink = new System.Windows.Forms.LinkLabel();
            this._deletePlayerLink = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._turnHistoryText = new System.Windows.Forms.TextBox();
            this._robberLocationLabel = new System.Windows.Forms.Label();
            this._robberLocation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._assignPropertiesLink = new System.Windows.Forms.LinkLabel();
            this._gameStatistics = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._letterDistributionByCount = new System.Windows.Forms.TextBox();
            this._letterDistributionByLetter = new System.Windows.Forms.TextBox();
            this._letterDistributionAnalysis = new System.Windows.Forms.TextBox();
            this._tileCountSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._randomnessTypeSelector = new System.Windows.Forms.ComboBox();
            this._baseWeightLabel = new System.Windows.Forms.Label();
            this._baseWeightSelector = new System.Windows.Forms.NumericUpDown();
            this._addWeightLabel = new System.Windows.Forms.Label();
            this._addWeightSelector = new System.Windows.Forms.NumericUpDown();
            this._weightingSettings = new System.Windows.Forms.Panel();
            this._robberSettings = new System.Windows.Forms.Panel();
            this._multiplicativeSettings = new System.Windows.Forms.Panel();
            this._weightFactorSelector = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._groupSelectSettings = new System.Windows.Forms.Panel();
            this._refreshGroupingsSelector = new System.Windows.Forms.CheckBox();
            this._doubleRefreshSelector = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._baseWeightSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._addWeightSelector)).BeginInit();
            this._weightingSettings.SuspendLayout();
            this._robberSettings.SuspendLayout();
            this._multiplicativeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._weightFactorSelector)).BeginInit();
            this._groupSelectSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // _rollButton
            // 
            this._rollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._rollButton.Enabled = false;
            this._rollButton.Location = new System.Drawing.Point(900, 13);
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
            this._turnStatus.Size = new System.Drawing.Size(963, 54);
            this._turnStatus.TabIndex = 1;
            this._turnStatus.TabStop = false;
            this._turnStatus.Text = "Turn 0 - Player";
            this._turnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 59);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // _secondTile
            // 
            this._secondTile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._secondTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this._secondTile.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._secondTile.Location = new System.Drawing.Point(332, 3);
            this._secondTile.Name = "_secondTile";
            this._secondTile.ReadOnly = true;
            this._secondTile.Size = new System.Drawing.Size(323, 54);
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
            this._thirdTile.Location = new System.Drawing.Point(661, 3);
            this._thirdTile.Name = "_thirdTile";
            this._thirdTile.ReadOnly = true;
            this._thirdTile.Size = new System.Drawing.Size(323, 54);
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
            this._firstTile.Size = new System.Drawing.Size(323, 54);
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
            this._playersList.Location = new System.Drawing.Point(3, 16);
            this._playersList.Name = "_playersList";
            this._playersList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._playersList.Size = new System.Drawing.Size(209, 439);
            this._playersList.TabIndex = 5;
            this._playersList.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this._addPlayerLink);
            this.groupBox1.Controls.Add(this._deletePlayerLink);
            this.groupBox1.Controls.Add(this._playersList);
            this.groupBox1.Location = new System.Drawing.Point(0, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 458);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
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
            this._addPlayerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // _deletePlayerLink
            // 
            this._deletePlayerLink.AutoSize = true;
            this._deletePlayerLink.Location = new System.Drawing.Point(170, 0);
            this._deletePlayerLink.Name = "_deletePlayerLink";
            this._deletePlayerLink.Size = new System.Drawing.Size(38, 13);
            this._deletePlayerLink.TabIndex = 6;
            this._deletePlayerLink.TabStop = true;
            this._deletePlayerLink.Text = "Delete";
            this._deletePlayerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._turnHistoryText);
            this.groupBox2.Location = new System.Drawing.Point(222, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 458);
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
            this._turnHistoryText.Size = new System.Drawing.Size(509, 439);
            this._turnHistoryText.TabIndex = 0;
            this._turnHistoryText.TabStop = false;
            // 
            // _robberLocationLabel
            // 
            this._robberLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._robberLocationLabel.AutoSize = true;
            this._robberLocationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._robberLocationLabel.ForeColor = System.Drawing.Color.Firebrick;
            this._robberLocationLabel.Location = new System.Drawing.Point(44, 3);
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
            this._robberLocation.Location = new System.Drawing.Point(169, 6);
            this._robberLocation.Name = "_robberLocation";
            this._robberLocation.Size = new System.Drawing.Size(108, 38);
            this._robberLocation.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._assignPropertiesLink);
            this.groupBox3.Controls.Add(this._gameStatistics);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this._letterDistributionAnalysis);
            this.groupBox3.Location = new System.Drawing.Point(743, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 456);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Letter Distribution";
            // 
            // _assignPropertiesLink
            // 
            this._assignPropertiesLink.AutoSize = true;
            this._assignPropertiesLink.Location = new System.Drawing.Point(144, 0);
            this._assignPropertiesLink.Name = "_assignPropertiesLink";
            this._assignPropertiesLink.Size = new System.Drawing.Size(92, 13);
            this._assignPropertiesLink.TabIndex = 3;
            this._assignPropertiesLink.TabStop = true;
            this._assignPropertiesLink.Text = "Assign Resources";
            this._assignPropertiesLink.Visible = false;
            this._assignPropertiesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._assignPropertiesLink_LinkClicked);
            // 
            // _gameStatistics
            // 
            this._gameStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._gameStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._gameStatistics.Location = new System.Drawing.Point(7, 417);
            this._gameStatistics.Name = "_gameStatistics";
            this._gameStatistics.ReadOnly = true;
            this._gameStatistics.Size = new System.Drawing.Size(225, 13);
            this._gameStatistics.TabIndex = 2;
            this._gameStatistics.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
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
            this._letterDistributionAnalysis.Size = new System.Drawing.Size(225, 13);
            this._letterDistributionAnalysis.TabIndex = 0;
            this._letterDistributionAnalysis.TabStop = false;
            // 
            // _tileCountSelector
            // 
            this._tileCountSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._tileCountSelector.FormattingEnabled = true;
            this._tileCountSelector.Location = new System.Drawing.Point(122, 11);
            this._tileCountSelector.Name = "_tileCountSelector";
            this._tileCountSelector.Size = new System.Drawing.Size(61, 21);
            this._tileCountSelector.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Randomness";
            // 
            // _randomnessTypeSelector
            // 
            this._randomnessTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._randomnessTypeSelector.FormattingEnabled = true;
            this._randomnessTypeSelector.Location = new System.Drawing.Point(280, 11);
            this._randomnessTypeSelector.Name = "_randomnessTypeSelector";
            this._randomnessTypeSelector.Size = new System.Drawing.Size(121, 21);
            this._randomnessTypeSelector.TabIndex = 13;
            this._randomnessTypeSelector.SelectionChangeCommitted += new System.EventHandler(this._randomnessTypeSelector_SelectionChangeCommitted);
            // 
            // _baseWeightLabel
            // 
            this._baseWeightLabel.AutoSize = true;
            this._baseWeightLabel.Location = new System.Drawing.Point(8, 12);
            this._baseWeightLabel.Name = "_baseWeightLabel";
            this._baseWeightLabel.Size = new System.Drawing.Size(51, 13);
            this._baseWeightLabel.TabIndex = 14;
            this._baseWeightLabel.Text = "Base Wt.";
            // 
            // _baseWeightSelector
            // 
            this._baseWeightSelector.Location = new System.Drawing.Point(56, 10);
            this._baseWeightSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._baseWeightSelector.Name = "_baseWeightSelector";
            this._baseWeightSelector.Size = new System.Drawing.Size(39, 20);
            this._baseWeightSelector.TabIndex = 15;
            this._baseWeightSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _addWeightLabel
            // 
            this._addWeightLabel.AutoSize = true;
            this._addWeightLabel.Location = new System.Drawing.Point(101, 12);
            this._addWeightLabel.Name = "_addWeightLabel";
            this._addWeightLabel.Size = new System.Drawing.Size(46, 13);
            this._addWeightLabel.TabIndex = 16;
            this._addWeightLabel.Text = "Add Wt.";
            // 
            // _addWeightSelector
            // 
            this._addWeightSelector.Location = new System.Drawing.Point(144, 10);
            this._addWeightSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._addWeightSelector.Name = "_addWeightSelector";
            this._addWeightSelector.Size = new System.Drawing.Size(39, 20);
            this._addWeightSelector.TabIndex = 17;
            this._addWeightSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _weightingSettings
            // 
            this._weightingSettings.Controls.Add(this._addWeightSelector);
            this._weightingSettings.Controls.Add(this._addWeightLabel);
            this._weightingSettings.Controls.Add(this._baseWeightSelector);
            this._weightingSettings.Controls.Add(this._baseWeightLabel);
            this._weightingSettings.Location = new System.Drawing.Point(407, 2);
            this._weightingSettings.Name = "_weightingSettings";
            this._weightingSettings.Size = new System.Drawing.Size(201, 47);
            this._weightingSettings.TabIndex = 14;
            this._weightingSettings.Visible = false;
            // 
            // _robberSettings
            // 
            this._robberSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._robberSettings.Controls.Add(this._robberLocation);
            this._robberSettings.Controls.Add(this._robberLocationLabel);
            this._robberSettings.Location = new System.Drawing.Point(614, 2);
            this._robberSettings.Name = "_robberSettings";
            this._robberSettings.Size = new System.Drawing.Size(280, 47);
            this._robberSettings.TabIndex = 15;
            this._robberSettings.Visible = false;
            // 
            // _multiplicativeSettings
            // 
            this._multiplicativeSettings.Controls.Add(this._weightFactorSelector);
            this._multiplicativeSettings.Controls.Add(this.label4);
            this._multiplicativeSettings.Location = new System.Drawing.Point(407, 2);
            this._multiplicativeSettings.Name = "_multiplicativeSettings";
            this._multiplicativeSettings.Size = new System.Drawing.Size(201, 47);
            this._multiplicativeSettings.TabIndex = 18;
            this._multiplicativeSettings.Visible = false;
            // 
            // _weightFactorSelector
            // 
            this._weightFactorSelector.DecimalPlaces = 2;
            this._weightFactorSelector.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this._weightFactorSelector.Location = new System.Drawing.Point(71, 10);
            this._weightFactorSelector.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            65536});
            this._weightFactorSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._weightFactorSelector.Name = "_weightFactorSelector";
            this._weightFactorSelector.Size = new System.Drawing.Size(42, 20);
            this._weightFactorSelector.TabIndex = 15;
            this._weightFactorSelector.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Wt. Factor";
            // 
            // _groupSelectSettings
            // 
            this._groupSelectSettings.Controls.Add(this._doubleRefreshSelector);
            this._groupSelectSettings.Controls.Add(this._refreshGroupingsSelector);
            this._groupSelectSettings.Location = new System.Drawing.Point(407, 2);
            this._groupSelectSettings.Name = "_groupSelectSettings";
            this._groupSelectSettings.Size = new System.Drawing.Size(201, 47);
            this._groupSelectSettings.TabIndex = 18;
            this._groupSelectSettings.Visible = false;
            // 
            // _refreshGroupingsSelector
            // 
            this._refreshGroupingsSelector.AutoSize = true;
            this._refreshGroupingsSelector.Location = new System.Drawing.Point(8, 6);
            this._refreshGroupingsSelector.Name = "_refreshGroupingsSelector";
            this._refreshGroupingsSelector.Size = new System.Drawing.Size(114, 17);
            this._refreshGroupingsSelector.TabIndex = 18;
            this._refreshGroupingsSelector.Text = "Refresh Groupings";
            this._refreshGroupingsSelector.UseVisualStyleBackColor = true;
            this._refreshGroupingsSelector.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // _doubleRefreshSelector
            // 
            this._doubleRefreshSelector.AutoSize = true;
            this._doubleRefreshSelector.Location = new System.Drawing.Point(8, 23);
            this._doubleRefreshSelector.Name = "_doubleRefreshSelector";
            this._doubleRefreshSelector.Size = new System.Drawing.Size(78, 17);
            this._doubleRefreshSelector.TabIndex = 19;
            this._doubleRefreshSelector.Text = "More Even";
            this._doubleRefreshSelector.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(987, 614);
            this.Controls.Add(this._groupSelectSettings);
            this.Controls.Add(this._weightingSettings);
            this.Controls.Add(this._multiplicativeSettings);
            this.Controls.Add(this._robberSettings);
            this.Controls.Add(this._randomnessTypeSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tileCountSelector);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._turnStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._rollButton);
            this.Name = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this._baseWeightSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._addWeightSelector)).EndInit();
            this._weightingSettings.ResumeLayout(false);
            this._weightingSettings.PerformLayout();
            this._robberSettings.ResumeLayout(false);
            this._robberSettings.PerformLayout();
            this._multiplicativeSettings.ResumeLayout(false);
            this._multiplicativeSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._weightFactorSelector)).EndInit();
            this._groupSelectSettings.ResumeLayout(false);
            this._groupSelectSettings.PerformLayout();
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
        private System.Windows.Forms.TextBox _gameStatistics;
        private System.Windows.Forms.TextBox _letterDistributionByLetter;
        private System.Windows.Forms.LinkLabel _assignPropertiesLink;
        private System.Windows.Forms.TextBox _letterDistributionByCount;
        private System.Windows.Forms.ComboBox _tileCountSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _randomnessTypeSelector;
        private System.Windows.Forms.Label _baseWeightLabel;
        private System.Windows.Forms.NumericUpDown _baseWeightSelector;
        private System.Windows.Forms.Label _addWeightLabel;
        private System.Windows.Forms.NumericUpDown _addWeightSelector;
        private System.Windows.Forms.Panel _weightingSettings;
        private System.Windows.Forms.Panel _robberSettings;
        private System.Windows.Forms.Panel _multiplicativeSettings;
        private System.Windows.Forms.NumericUpDown _weightFactorSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel _groupSelectSettings;
        private System.Windows.Forms.CheckBox _refreshGroupingsSelector;
        private System.Windows.Forms.CheckBox _doubleRefreshSelector;
    }
}

