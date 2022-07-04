namespace ContactTracingApp.Dalangin
{
    partial class Scanner_Form
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
            this.components = new System.ComponentModel.Container();
            this.cameradevicesComboBox = new System.Windows.Forms.ComboBox();
            this.scannedqrTextBox = new System.Windows.Forms.RichTextBox();
            this.cameraLabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.scannerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameradevicesComboBox
            // 
            this.cameradevicesComboBox.FormattingEnabled = true;
            this.cameradevicesComboBox.Location = new System.Drawing.Point(110, 55);
            this.cameradevicesComboBox.Name = "cameradevicesComboBox";
            this.cameradevicesComboBox.Size = new System.Drawing.Size(121, 23);
            this.cameradevicesComboBox.TabIndex = 0;
            // 
            // scannedqrTextBox
            // 
            this.scannedqrTextBox.Location = new System.Drawing.Point(325, 84);
            this.scannedqrTextBox.Name = "scannedqrTextBox";
            this.scannedqrTextBox.Size = new System.Drawing.Size(237, 259);
            this.scannedqrTextBox.TabIndex = 1;
            this.scannedqrTextBox.Text = "";
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Location = new System.Drawing.Point(53, 58);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(51, 15);
            this.cameraLabel.TabIndex = 2;
            this.cameraLabel.Text = "Camera:";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(237, 55);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 3;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(487, 349);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Fill in Personal Data";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputPictureBox.Location = new System.Drawing.Point(53, 84);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(266, 259);
            this.outputPictureBox.TabIndex = 5;
            this.outputPictureBox.TabStop = false;
            // 
            // scannerTimer
            // 
            this.scannerTimer.Interval = 1000;
            this.scannerTimer.Tick += new System.EventHandler(this.scannerTimer_Tick);
            // 
            // Scanner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 388);
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.cameraLabel);
            this.Controls.Add(this.scannedqrTextBox);
            this.Controls.Add(this.cameradevicesComboBox);
            this.Name = "Scanner_Form";
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scanner_Form_FormClosing);
            this.Load += new System.EventHandler(this.Scanner_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cameradevicesComboBox;
        private RichTextBox scannedqrTextBox;
        private Label cameraLabel;
        private Button previewButton;
        private Button saveButton;
        private PictureBox outputPictureBox;
        private System.Windows.Forms.Timer scannerTimer;
    }
}