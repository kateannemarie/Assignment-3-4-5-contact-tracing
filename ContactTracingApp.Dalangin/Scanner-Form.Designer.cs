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
            this.cameraLabel = new System.Windows.Forms.Label();
            this.cameradeviceComboBox = new System.Windows.Forms.ComboBox();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.scannerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Location = new System.Drawing.Point(32, 66);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(51, 15);
            this.cameraLabel.TabIndex = 0;
            this.cameraLabel.Text = "Camera:";
            // 
            // cameradeviceComboBox
            // 
            this.cameradeviceComboBox.FormattingEnabled = true;
            this.cameradeviceComboBox.Location = new System.Drawing.Point(89, 63);
            this.cameradeviceComboBox.Name = "cameradeviceComboBox";
            this.cameradeviceComboBox.Size = new System.Drawing.Size(220, 23);
            this.cameradeviceComboBox.TabIndex = 1;
            this.cameradeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.cameradeviceComboBox_SelectedIndexChanged);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputPictureBox.Location = new System.Drawing.Point(32, 103);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(305, 269);
            this.outputPictureBox.TabIndex = 2;
            this.outputPictureBox.TabStop = false;
            this.outputPictureBox.Click += new System.EventHandler(this.outputPictureBox_Click);
            // 
            // scannerTimer
            // 
            this.scannerTimer.Tick += new System.EventHandler(this.scannerTimer_Tick);
            // 
            // Scanner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 389);
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.cameradeviceComboBox);
            this.Controls.Add(this.cameraLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(387, 432);
            this.MinimumSize = new System.Drawing.Size(387, 432);
            this.Name = "Scanner_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scanner_Form_FormClosing);
            this.Load += new System.EventHandler(this.Scanner_Form_Load);
            this.Shown += new System.EventHandler(this.Scanner_Form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cameraLabel;
        private ComboBox cameradeviceComboBox;
        private PictureBox outputPictureBox;
        private System.Windows.Forms.Timer scannerTimer;
    }
}