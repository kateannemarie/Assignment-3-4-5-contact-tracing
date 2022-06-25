namespace ContactTracingApp.Dalangin
{
    partial class Filter_Data
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
            this.fullData = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.datalistBox = new System.Windows.Forms.ListBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.twentyButton = new System.Windows.Forms.Button();
            this.twentyoneButton = new System.Windows.Forms.Button();
            this.twentytwoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullData
            // 
            this.fullData.AutoSize = true;
            this.fullData.Location = new System.Drawing.Point(21, 40);
            this.fullData.Name = "fullData";
            this.fullData.Size = new System.Drawing.Size(0, 15);
            this.fullData.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 406);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 32);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // datalistBox
            // 
            this.datalistBox.FormattingEnabled = true;
            this.datalistBox.ItemHeight = 15;
            this.datalistBox.Location = new System.Drawing.Point(21, 67);
            this.datalistBox.Name = "datalistBox";
            this.datalistBox.Size = new System.Drawing.Size(372, 319);
            this.datalistBox.TabIndex = 6;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(27, 40);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(103, 15);
            this.filterLabel.TabIndex = 7;
            this.filterLabel.Text = "Filter data by year:";
            this.filterLabel.Click += new System.EventHandler(this.filterLabel_Click);
            // 
            // twentyButton
            // 
            this.twentyButton.Location = new System.Drawing.Point(144, 36);
            this.twentyButton.Name = "twentyButton";
            this.twentyButton.Size = new System.Drawing.Size(75, 23);
            this.twentyButton.TabIndex = 8;
            this.twentyButton.Text = "2020";
            this.twentyButton.UseVisualStyleBackColor = true;
            this.twentyButton.Click += new System.EventHandler(this.twentyButton_Click);
            // 
            // twentyoneButton
            // 
            this.twentyoneButton.Location = new System.Drawing.Point(225, 36);
            this.twentyoneButton.Name = "twentyoneButton";
            this.twentyoneButton.Size = new System.Drawing.Size(75, 23);
            this.twentyoneButton.TabIndex = 9;
            this.twentyoneButton.Text = "2021";
            this.twentyoneButton.UseVisualStyleBackColor = true;
            this.twentyoneButton.Click += new System.EventHandler(this.twentyoneButton_Click);
            // 
            // twentytwoButton
            // 
            this.twentytwoButton.Location = new System.Drawing.Point(306, 36);
            this.twentytwoButton.Name = "twentytwoButton";
            this.twentytwoButton.Size = new System.Drawing.Size(75, 23);
            this.twentytwoButton.TabIndex = 10;
            this.twentytwoButton.Text = "2022";
            this.twentytwoButton.UseVisualStyleBackColor = true;
            this.twentytwoButton.Click += new System.EventHandler(this.twentytwoButton_Click);
            // 
            // Filter_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.twentytwoButton);
            this.Controls.Add(this.twentyoneButton);
            this.Controls.Add(this.twentyButton);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.datalistBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.fullData);
            this.Name = "Filter_Data";
            this.Text = "Filter Data";
            this.Load += new System.EventHandler(this.Filter_Data_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label fullData;
        private Button backButton;
        private ListBox datalistBox;
        private Label filterLabel;
        private Button twentyButton;
        private Button twentyoneButton;
        private Button twentytwoButton;
    }
}