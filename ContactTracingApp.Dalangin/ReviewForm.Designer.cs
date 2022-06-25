namespace ContactTracingApp.Dalangin
{
    partial class ReviewForm
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.reviewListBox = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.searchdataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 22);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(357, 15);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Please click show data to check if the information below is correct.\r\n";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // reviewListBox
            // 
            this.reviewListBox.FormattingEnabled = true;
            this.reviewListBox.HorizontalScrollbar = true;
            this.reviewListBox.ItemHeight = 15;
            this.reviewListBox.Location = new System.Drawing.Point(38, 40);
            this.reviewListBox.Name = "reviewListBox";
            this.reviewListBox.ScrollAlwaysVisible = true;
            this.reviewListBox.Size = new System.Drawing.Size(651, 349);
            this.reviewListBox.TabIndex = 1;
            this.reviewListBox.SelectedIndexChanged += new System.EventHandler(this.reviewListBox_SelectedIndexChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(172, 395);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(117, 43);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show data";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(295, 395);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(117, 43);
            this.saveData.TabIndex = 4;
            this.saveData.Text = "Submit and Exit";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // searchdataButton
            // 
            this.searchdataButton.Location = new System.Drawing.Point(418, 395);
            this.searchdataButton.Name = "searchdataButton";
            this.searchdataButton.Size = new System.Drawing.Size(117, 43);
            this.searchdataButton.TabIndex = 5;
            this.searchdataButton.Text = "Search data";
            this.searchdataButton.UseVisualStyleBackColor = true;
            this.searchdataButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.ControlBox = false;
            this.Controls.Add(this.searchdataButton);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.reviewListBox);
            this.Controls.Add(this.descriptionLabel);
            this.MaximumSize = new System.Drawing.Size(717, 489);
            this.MinimumSize = new System.Drawing.Size(717, 489);
            this.Name = "ReviewForm";
            this.Text = "Review Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label descriptionLabel;
        private ListBox reviewListBox;
        private Button showButton;
        private Button saveData;
        private Button searchdataButton;
    }
}