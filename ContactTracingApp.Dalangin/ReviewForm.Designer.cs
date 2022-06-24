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
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 22);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(259, 15);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Please check if the information below is correct.\r\n";
            // 
            // reviewListBox
            // 
            this.reviewListBox.FormattingEnabled = true;
            this.reviewListBox.ItemHeight = 15;
            this.reviewListBox.Location = new System.Drawing.Point(38, 48);
            this.reviewListBox.Name = "reviewListBox";
            this.reviewListBox.Size = new System.Drawing.Size(496, 349);
            this.reviewListBox.TabIndex = 1;
            this.reviewListBox.SelectedIndexChanged += new System.EventHandler(this.reviewListBox_SelectedIndexChanged);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reviewListBox);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "ReviewForm";
            this.Text = "Review Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label descriptionLabel;
        private ListBox reviewListBox;
    }
}