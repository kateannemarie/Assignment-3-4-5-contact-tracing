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
            this.cameraLabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.scannerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameradevicesComboBox
            // 
            this.cameradevicesComboBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cameradevicesComboBox.FormattingEnabled = true;
            this.cameradevicesComboBox.Location = new System.Drawing.Point(94, 55);
            this.cameradevicesComboBox.Name = "cameradevicesComboBox";
            this.cameradevicesComboBox.Size = new System.Drawing.Size(137, 23);
            this.cameradevicesComboBox.TabIndex = 0;
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cameraLabel.Location = new System.Drawing.Point(30, 57);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(58, 17);
            this.cameraLabel.TabIndex = 2;
            this.cameraLabel.Text = "Camera:";
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previewButton.Location = new System.Drawing.Point(244, 55);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(91, 23);
            this.previewButton.TabIndex = 3;
            this.previewButton.Text = "Scan";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputPictureBox.Location = new System.Drawing.Point(32, 84);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(303, 292);
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
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(378, 388);
            this.ControlBox = false;
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.cameraLabel);
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
        private Label cameraLabel;
        private Button previewButton;
        private PictureBox outputPictureBox;
        private System.Windows.Forms.Timer scannerTimer;
    }
}