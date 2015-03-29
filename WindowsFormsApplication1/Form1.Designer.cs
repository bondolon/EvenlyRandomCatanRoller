﻿namespace WindowsFormsApplication1
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
            this._resourceTileCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._secondTile = new System.Windows.Forms.TextBox();
            this._thirdTile = new System.Windows.Forms.TextBox();
            this._firstTile = new System.Windows.Forms.TextBox();
            this._playersList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._turnHistoryText = new System.Windows.Forms.TextBox();
            this._robberLocationLabel = new System.Windows.Forms.Label();
            this._robberLocation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._assignPropertiesLink = new System.Windows.Forms.LinkLabel();
            this._gameStatistics = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._letterDistributionByLetter = new System.Windows.Forms.TextBox();
            this._letterDistributionAnalysis = new System.Windows.Forms.TextBox();
            this._enableEvenExhaustion = new System.Windows.Forms.CheckBox();
            this._letterDistributionByCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._resourceTileCount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _rollButton
            // 
            this._rollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._rollButton.Enabled = false;
            this._rollButton.Location = new System.Drawing.Point(824, 13);
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
            this._turnStatus.Size = new System.Drawing.Size(887, 54);
            this._turnStatus.TabIndex = 1;
            this._turnStatus.TabStop = false;
            this._turnStatus.Text = "Turn 0 - Player";
            this._turnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _resourceTileCount
            // 
            this._resourceTileCount.Location = new System.Drawing.Point(122, 12);
            this._resourceTileCount.Name = "_resourceTileCount";
            this._resourceTileCount.ReadOnly = true;
            this._resourceTileCount.Size = new System.Drawing.Size(63, 20);
            this._resourceTileCount.TabIndex = 2;
            this._resourceTileCount.TabStop = false;
            this._resourceTileCount.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 59);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // _secondTile
            // 
            this._secondTile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._secondTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this._secondTile.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._secondTile.Location = new System.Drawing.Point(306, 3);
            this._secondTile.Name = "_secondTile";
            this._secondTile.ReadOnly = true;
            this._secondTile.Size = new System.Drawing.Size(297, 54);
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
            this._thirdTile.Location = new System.Drawing.Point(609, 3);
            this._thirdTile.Name = "_thirdTile";
            this._thirdTile.ReadOnly = true;
            this._thirdTile.Size = new System.Drawing.Size(299, 54);
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
            this._firstTile.Size = new System.Drawing.Size(297, 54);
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
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this._playersList);
            this.groupBox1.Location = new System.Drawing.Point(0, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 458);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(139, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(26, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(171, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Delete";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._turnHistoryText);
            this.groupBox2.Location = new System.Drawing.Point(222, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 458);
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
            this._turnHistoryText.Size = new System.Drawing.Size(433, 439);
            this._turnHistoryText.TabIndex = 0;
            this._turnHistoryText.TabStop = false;
            // 
            // _robberLocationLabel
            // 
            this._robberLocationLabel.AutoSize = true;
            this._robberLocationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._robberLocationLabel.ForeColor = System.Drawing.Color.Firebrick;
            this._robberLocationLabel.Location = new System.Drawing.Point(314, 3);
            this._robberLocationLabel.Name = "_robberLocationLabel";
            this._robberLocationLabel.Size = new System.Drawing.Size(119, 37);
            this._robberLocationLabel.TabIndex = 8;
            this._robberLocationLabel.Text = "Robber:";
            // 
            // _robberLocation
            // 
            this._robberLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._robberLocation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._robberLocation.FormattingEnabled = true;
            this._robberLocation.Items.AddRange(new object[] {
            "A"});
            this._robberLocation.Location = new System.Drawing.Point(439, 6);
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
            this.groupBox3.Location = new System.Drawing.Point(667, 153);
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
            // _enableEvenExhaustion
            // 
            this._enableEvenExhaustion.AutoSize = true;
            this._enableEvenExhaustion.Location = new System.Drawing.Point(191, 13);
            this._enableEvenExhaustion.Name = "_enableEvenExhaustion";
            this._enableEvenExhaustion.Size = new System.Drawing.Size(106, 17);
            this._enableEvenExhaustion.TabIndex = 11;
            this._enableEvenExhaustion.TabStop = false;
            this._enableEvenExhaustion.Text = "Even Exhaustion";
            this._enableEvenExhaustion.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(911, 614);
            this.Controls.Add(this._enableEvenExhaustion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this._robberLocation);
            this.Controls.Add(this._robberLocationLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._turnStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._resourceTileCount);
            this.Controls.Add(this._rollButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._resourceTileCount)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _rollButton;
        private System.Windows.Forms.TextBox _turnStatus;
        private System.Windows.Forms.NumericUpDown _resourceTileCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _secondTile;
        private System.Windows.Forms.TextBox _thirdTile;
        private System.Windows.Forms.TextBox _firstTile;
        private System.Windows.Forms.ListBox _playersList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _turnHistoryText;
        private System.Windows.Forms.Label _robberLocationLabel;
        private System.Windows.Forms.ComboBox _robberLocation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _letterDistributionAnalysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox _gameStatistics;
        private System.Windows.Forms.TextBox _letterDistributionByLetter;
        private System.Windows.Forms.CheckBox _enableEvenExhaustion;
        private System.Windows.Forms.LinkLabel _assignPropertiesLink;
        private System.Windows.Forms.TextBox _letterDistributionByCount;
    }
}
