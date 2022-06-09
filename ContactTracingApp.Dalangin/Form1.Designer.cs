namespace ContactTracingApp.Dalangin
{
    partial class logbookForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logbookForm));
            this.upperLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactnumberLabel = new System.Windows.Forms.Label();
            this.contactnumberTextBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.healthdeclarationButton = new System.Windows.Forms.Button();
            this.savedataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upperLabel
            // 
            this.upperLabel.AutoSize = true;
            this.upperLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.upperLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upperLabel.Location = new System.Drawing.Point(12, 9);
            this.upperLabel.Name = "upperLabel";
            this.upperLabel.Size = new System.Drawing.Size(121, 32);
            this.upperLabel.TabIndex = 0;
            this.upperLabel.Text = "Log Book";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.White;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(12, 53);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(252, 17);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Please fill out honestly the form below.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 170);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(275, 23);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 211);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 15);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(12, 229);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(275, 23);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // contactnumberLabel
            // 
            this.contactnumberLabel.AutoSize = true;
            this.contactnumberLabel.Location = new System.Drawing.Point(12, 271);
            this.contactnumberLabel.Name = "contactnumberLabel";
            this.contactnumberLabel.Size = new System.Drawing.Size(99, 15);
            this.contactnumberLabel.TabIndex = 6;
            this.contactnumberLabel.Text = "Contact Number:";
            this.contactnumberLabel.Click += new System.EventHandler(this.contactnumberLabel_Click);
            // 
            // contactnumberTextBox
            // 
            this.contactnumberTextBox.Location = new System.Drawing.Point(12, 289);
            this.contactnumberTextBox.Name = "contactnumberTextBox";
            this.contactnumberTextBox.Size = new System.Drawing.Size(275, 23);
            this.contactnumberTextBox.TabIndex = 7;
            this.contactnumberTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(12, 113);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 23);
            this.datePicker.TabIndex = 8;
            this.datePicker.Value = new System.DateTime(2022, 6, 9, 22, 55, 53, 0);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 95);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 15);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date:";
            // 
            // healthdeclarationButton
            // 
            this.healthdeclarationButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.healthdeclarationButton.Location = new System.Drawing.Point(155, 330);
            this.healthdeclarationButton.Name = "healthdeclarationButton";
            this.healthdeclarationButton.Size = new System.Drawing.Size(132, 40);
            this.healthdeclarationButton.TabIndex = 10;
            this.healthdeclarationButton.Text = "Health Declaration Form";
            this.healthdeclarationButton.UseVisualStyleBackColor = true;
            this.healthdeclarationButton.Click += new System.EventHandler(this.healthdeclarationButton_Click);
            // 
            // savedataButton
            // 
            this.savedataButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savedataButton.Location = new System.Drawing.Point(12, 330);
            this.savedataButton.Name = "savedataButton";
            this.savedataButton.Size = new System.Drawing.Size(132, 40);
            this.savedataButton.TabIndex = 11;
            this.savedataButton.Text = "Submit";
            this.savedataButton.UseVisualStyleBackColor = true;
            this.savedataButton.Click += new System.EventHandler(this.savedataButton_Click);
            // 
            // logbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 382);
            this.Controls.Add(this.savedataButton);
            this.Controls.Add(this.healthdeclarationButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.contactnumberTextBox);
            this.Controls.Add(this.contactnumberLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.upperLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 421);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 421);
            this.Name = "logbookForm";
            this.Text = "Log Book Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label upperLabel;
        private Label descriptionLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label contactnumberLabel;
        private TextBox contactnumberTextBox;
        private DateTimePicker datePicker;
        private Label dateLabel;
        private Button healthdeclarationButton;
        private Button savedataButton;
    }
}