﻿namespace ContactTracingApp.Dalangin
{
    partial class Form1
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
            this.upperLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactnumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateandtimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateandtimeLabel = new System.Windows.Forms.Label();
            this.healthdeclarationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upperLabel
            // 
            this.upperLabel.AutoSize = true;
            this.upperLabel.BackColor = System.Drawing.Color.Silver;
            this.upperLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upperLabel.Location = new System.Drawing.Point(12, 9);
            this.upperLabel.Name = "upperLabel";
            this.upperLabel.Size = new System.Drawing.Size(259, 32);
            this.upperLabel.TabIndex = 0;
            this.upperLabel.Text = "Contact Tracing Form";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 53);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(212, 15);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 23);
            this.textBox1.TabIndex = 7;
            // 
            // dateandtimePicker
            // 
            this.dateandtimePicker.Location = new System.Drawing.Point(12, 113);
            this.dateandtimePicker.Name = "dateandtimePicker";
            this.dateandtimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateandtimePicker.TabIndex = 8;
            // 
            // dateandtimeLabel
            // 
            this.dateandtimeLabel.AutoSize = true;
            this.dateandtimeLabel.Location = new System.Drawing.Point(12, 95);
            this.dateandtimeLabel.Name = "dateandtimeLabel";
            this.dateandtimeLabel.Size = new System.Drawing.Size(86, 15);
            this.dateandtimeLabel.TabIndex = 9;
            this.dateandtimeLabel.Text = "Date and Time:";
            // 
            // healthdeclarationButton
            // 
            this.healthdeclarationButton.Location = new System.Drawing.Point(71, 330);
            this.healthdeclarationButton.Name = "healthdeclarationButton";
            this.healthdeclarationButton.Size = new System.Drawing.Size(153, 40);
            this.healthdeclarationButton.TabIndex = 10;
            this.healthdeclarationButton.Text = "Health Declaration Form";
            this.healthdeclarationButton.UseVisualStyleBackColor = true;
            this.healthdeclarationButton.Click += new System.EventHandler(this.healthdeclarationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 382);
            this.Controls.Add(this.healthdeclarationButton);
            this.Controls.Add(this.dateandtimeLabel);
            this.Controls.Add(this.dateandtimePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.contactnumberLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.upperLabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private TextBox textBox1;
        private DateTimePicker dateandtimePicker;
        private Label dateandtimeLabel;
        private Button healthdeclarationButton;
    }
}