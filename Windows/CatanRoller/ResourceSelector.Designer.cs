namespace WindowsFormsApplication1
{
    partial class ResourceSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Letter = new System.Windows.Forms.Label();
            this.ResourceType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Letter
            // 
            this.Letter.AutoSize = true;
            this.Letter.Location = new System.Drawing.Point(2, 4);
            this.Letter.Name = "Letter";
            this.Letter.Size = new System.Drawing.Size(11, 13);
            this.Letter.TabIndex = 0;
            this.Letter.Text = "*";
            // 
            // ResourceType
            // 
            this.ResourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourceType.FormattingEnabled = true;
            this.ResourceType.Items.AddRange(new object[] {
            "",
            "Ore",
            "Wheat",
            "Sheep",
            "Lumber",
            "Brick"});
            this.ResourceType.Location = new System.Drawing.Point(19, 0);
            this.ResourceType.Name = "ResourceType";
            this.ResourceType.Size = new System.Drawing.Size(122, 20);
            this.ResourceType.TabIndex = 1;
            this.ResourceType.SelectedIndexChanged += new System.EventHandler(this.ResourceType_SelectedIndexChanged);
            // 
            // ResourceSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResourceType);
            this.Controls.Add(this.Letter);
            this.Name = "ResourceSelector";
            this.Size = new System.Drawing.Size(144, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Letter;
        public System.Windows.Forms.ComboBox ResourceType;
    }
}
