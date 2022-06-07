namespace ContactTracingApp.Dalangin
{
    partial class Health_Declaration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Health_Declaration_Form));
            this.reminderLabel = new System.Windows.Forms.Label();
            this.personaldataLabel = new System.Windows.Forms.Label();
            this.namelLabel2 = new System.Windows.Forms.Label();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.contactaddressLabel = new System.Windows.Forms.Label();
            this.contactaddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reminderLabel
            // 
            this.reminderLabel.AutoSize = true;
            this.reminderLabel.Location = new System.Drawing.Point(12, 19);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(423, 45);
            this.reminderLabel.TabIndex = 0;
            this.reminderLabel.Text = resources.GetString("reminderLabel.Text");
            // 
            // personaldataLabel
            // 
            this.personaldataLabel.AutoSize = true;
            this.personaldataLabel.Location = new System.Drawing.Point(12, 91);
            this.personaldataLabel.Name = "personaldataLabel";
            this.personaldataLabel.Size = new System.Drawing.Size(82, 15);
            this.personaldataLabel.TabIndex = 1;
            this.personaldataLabel.Text = "Personal Data:";
            // 
            // namelLabel2
            // 
            this.namelLabel2.AutoSize = true;
            this.namelLabel2.Location = new System.Drawing.Point(12, 122);
            this.namelLabel2.Name = "namelLabel2";
            this.namelLabel2.Size = new System.Drawing.Size(42, 15);
            this.namelLabel2.TabIndex = 2;
            this.namelLabel2.Text = "Name:";
            this.namelLabel2.Click += new System.EventHandler(this.namelLabel2_Click);
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(12, 140);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(423, 23);
            this.nameTextBox2.TabIndex = 3;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(12, 181);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(28, 15);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Sex:";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(12, 199);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(63, 19);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(81, 199);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(51, 19);
            this.maleRadioButton.TabIndex = 7;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(221, 181);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(31, 15);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(221, 198);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 23);
            this.ageTextBox.TabIndex = 9;
            // 
            // contactaddressLabel
            // 
            this.contactaddressLabel.AutoSize = true;
            this.contactaddressLabel.Location = new System.Drawing.Point(12, 236);
            this.contactaddressLabel.Name = "contactaddressLabel";
            this.contactaddressLabel.Size = new System.Drawing.Size(97, 15);
            this.contactaddressLabel.TabIndex = 10;
            this.contactaddressLabel.Text = "Contact Address:";
            // 
            // contactaddressTextBox
            // 
            this.contactaddressTextBox.Location = new System.Drawing.Point(12, 254);
            this.contactaddressTextBox.Name = "contactaddressTextBox";
            this.contactaddressTextBox.Size = new System.Drawing.Size(423, 23);
            this.contactaddressTextBox.TabIndex = 11;
            // 
            // Health_Declaration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.contactaddressTextBox);
            this.Controls.Add(this.contactaddressLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.namelLabel2);
            this.Controls.Add(this.personaldataLabel);
            this.Controls.Add(this.reminderLabel);
            this.Name = "Health_Declaration_Form";
            this.Text = "Health Declaration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label reminderLabel;
        private Label personaldataLabel;
        private Label namelLabel2;
        private TextBox nameTextBox2;
        private Label sexLabel;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
        private Label ageLabel;
        private TextBox ageTextBox;
        private Label contactaddressLabel;
        private TextBox contactaddressTextBox;
    }
}