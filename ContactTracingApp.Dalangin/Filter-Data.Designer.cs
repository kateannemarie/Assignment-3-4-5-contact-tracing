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
            this.showfilteredListView = new System.Windows.Forms.ListView();
            this.datefilterPicker = new System.Windows.Forms.DateTimePicker();
            this.filterButton = new System.Windows.Forms.Button();
            this.fullData = new System.Windows.Forms.Label();
            this.datecolumnHead = new System.Windows.Forms.ColumnHeader();
            this.namecolumnHead = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // showfilteredListView
            // 
            this.showfilteredListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.datecolumnHead,
            this.namecolumnHead});
            this.showfilteredListView.Location = new System.Drawing.Point(289, 40);
            this.showfilteredListView.Name = "showfilteredListView";
            this.showfilteredListView.Size = new System.Drawing.Size(240, 290);
            this.showfilteredListView.TabIndex = 0;
            this.showfilteredListView.UseCompatibleStateImageBehavior = false;
            this.showfilteredListView.SelectedIndexChanged += new System.EventHandler(this.showfilteredListView_SelectedIndexChanged);
            // 
            // datefilterPicker
            // 
            this.datefilterPicker.Location = new System.Drawing.Point(21, 278);
            this.datefilterPicker.Name = "datefilterPicker";
            this.datefilterPicker.Size = new System.Drawing.Size(204, 23);
            this.datefilterPicker.TabIndex = 1;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(21, 307);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(88, 32);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Filter data";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // fullData
            // 
            this.fullData.AutoSize = true;
            this.fullData.Location = new System.Drawing.Point(21, 40);
            this.fullData.Name = "fullData";
            this.fullData.Size = new System.Drawing.Size(0, 15);
            this.fullData.TabIndex = 3;
            // 
            // datecolumnHead
            // 
            this.datecolumnHead.Text = "Date";
            // 
            // namecolumnHead
            // 
            this.namecolumnHead.Text = "Name";
            // 
            // Filter_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.fullData);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.datefilterPicker);
            this.Controls.Add(this.showfilteredListView);
            this.Name = "Filter_Data";
            this.Text = "Filter Data";
            this.Load += new System.EventHandler(this.Filter_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView showfilteredListView;
        private DateTimePicker datefilterPicker;
        private Button filterButton;
        private Label fullData;
        private ColumnHeader datecolumnHead;
        private ColumnHeader namecolumnHead;
    }
}